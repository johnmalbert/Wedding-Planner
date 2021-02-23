using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            //check for validation errors, ensure no two users have same email
            if(_context.Users.Any(u => u.Email == newUser.Email))
            {
                // email already exists in database
                ModelState.AddModelError("Email", "Email address is already in use.");
            }
            if(ModelState.IsValid)
            {
                //hash the password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                //add user to db
                _context.Add(newUser);
                _context.SaveChanges();

                //store id in session
                HttpContext.Session.SetInt32("UserId", newUser.UserId);

                // redirect to dashboard
                return RedirectToAction("Weddings");
            }
            
            return View("Index");
            
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser userToLogin)
        {
            // check if user exists in db
            var foundUser = _context.Users
                .FirstOrDefault(u => u.Email == userToLogin.LoginEmail);

            if(foundUser == null)
            {
                ModelState.AddModelError("LoginEmail", "Please check your email and password.");
                return View("Index");
            }
            // check password match
            var hasher = new PasswordHasher<LoginUser>();
            var result = hasher.VerifyHashedPassword(userToLogin, foundUser.Password, userToLogin.LoginPassword);

            if(result == 0)
            {
                ModelState.AddModelError("LoginEmail", "Please check your email and password.");
                return View("Index");
            }

            HttpContext.Session.SetInt32("UserId", foundUser.UserId);
            return RedirectToAction("Weddings");

            // check validation
        }

        [HttpGet("dashboard")]
        public IActionResult Weddings()
        {
            //get the user's info from session
            int? userId = HttpContext.Session.GetInt32("UserId");

            //check to ensure logged in
            if(userId == null)
            {
                return RedirectToAction("Index");
            }
            // pass user info to the view
            User CurrentUser = _context.Users
                .Include(u => u.RSVPS)
                .First(u => u.UserId == userId);

            List<Wedding> AllWeddings = _context.Weddings
                .Include(w => w.Creator)
                .Include(w => w.RSVPs)
                .ThenInclude(r => r.UserRSVPd)
                .ToList();

            //list weddings not rspd to
            List<Wedding> NonRSVPWeddings = _context.Weddings
                .Include(w => w.RSVPs)
                .Where(a => a.RSVPs.All(a => a.UserId != CurrentUser.UserId))
                .ToList();

            ViewBag.NotRSVPd = NonRSVPWeddings;
            ViewBag.CurrentUser = CurrentUser;
            return View(AllWeddings);
        }

        [HttpGet("wedding")]
        public IActionResult Wedding()
        {
            //check if logged in
            User CurrentUser = CheckLogin();
            if(CurrentUser == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost("newwedding")]
        public IActionResult NewWedding(Wedding newWedding)
        {
            //check if user is logged in
            User CurrentUser = CheckLogin();
            if(CurrentUser == null)
            {
                return RedirectToAction("Index");
            }
            //check if model is valid
            if(ModelState.IsValid)
            {
                //make sure the creator is the person logged in
                newWedding.Creator = CurrentUser;
                //add currentUser to the guest list
                //add wedding and rsvp to db
                _context.Add(newWedding);
                _context.SaveChanges();

                RSVP newRSVP = new RSVP();
                newRSVP.WeddingId = newWedding.WeddingId;
                newRSVP.UserId = CurrentUser.UserId;
                _context.Add(newRSVP);
                _context.SaveChanges();
                return Redirect($"weddings/{newWedding.WeddingId}");
            }
            ViewBag.CurrentUser = CurrentUser;
            return View("Wedding");
        }
        
        public User CheckLogin()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return null;
            }
            // pass user info to the view
            User CurrentUser = _context.Users
                .First(u => u.UserId == UserId);
            return (CurrentUser);
        }
        [HttpGet("weddings/{num}")]
        public IActionResult ShowWedding(int num)
        {
            ViewBag.CurrentUser = CheckLogin();
            if(ViewBag.CurrentUser == null)
            {
                return RedirectToAction("Index");
            }

            Wedding CurrentWedding = _context.Weddings
                .Include(w => w.RSVPs)
                .ThenInclude(r => r.UserRSVPd)
                .First(w => w.WeddingId == num);
            return View(CurrentWedding);
        }

        [HttpGet("RSVP/{num}")]
        public IActionResult RSVP(int num)
        {
            //get the user
            User CurrentUser = CheckLogin();
            if(CurrentUser == null)
            {
                return RedirectToAction("Index");
            }
            //get the wedding
            Wedding CurrentWedding = _context.Weddings
                .Include(w => w.RSVPs)
                .ThenInclude(w => w.UserRSVPd)
                .FirstOrDefault(w => w.WeddingId == num); 
            
            RSVP newRSVP = new RSVP();
            newRSVP.UserId = CurrentUser.UserId;
            newRSVP.WeddingId = num;

            _context.Add(newRSVP);
            _context.SaveChanges();

            //attach user to wedding 
            return RedirectToAction("Weddings");
        }

        [HttpGet("cancel/{num}")]
        public IActionResult Cancel(int num)
        {
            //get the user
            User CurrentUser = CheckLogin();
            if(CurrentUser == null)
            {
                return RedirectToAction("Index");
            }
            //get the wedding
            Wedding CurrentWedding = _context.Weddings
                .Include(w => w.RSVPs)
                .ThenInclude(w => w.UserRSVPd)
                .FirstOrDefault(w => w.WeddingId == num); 
            
            Console.WriteLine("Removing Wedding with ID " + CurrentWedding.WeddingId);
            _context.Remove(CurrentWedding);
            _context.SaveChanges();

            //remove the wedding from db
            return RedirectToAction("Weddings");
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
