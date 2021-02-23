using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required(ErrorMessage="Please enter a Groom")]
        [MinLength(2, ErrorMessage="Groom name must be at least two characters")]

        public string Groom { get; set; }
        
        [Required(ErrorMessage="Please enter a Bride")]
        [MinLength(2, ErrorMessage="Bride name must be at least twp characters")]
        public string Bride { get; set; }


        [Required(ErrorMessage="Please enter a Valid Date.")]
        [WeddingDate(ErrorMessage="Wedding Date must be in the future!")]
        public DateTime WeddingDate { get; set; }

        [Required(ErrorMessage="Please enter a Valid Address.")]
        [AddressAttribute(ErrorMessage="Please provide a zipcode.")]
        [MinLength(5, ErrorMessage="Address name must be at least five characters")]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public User Creator { get; set; }
        public List<RSVP> RSVPs { get; set; }
    }

    public class WeddingDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value == null)
                return true;

            var val = (DateTime)value;
            return (val > DateTime.Now);
        }
    }
    
    public class AddressAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value == null)
                return true;

            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            bool containsZip = false;
            string val = (string)value;
            string[] input = val.Split(" ");
            foreach (string item in input)
            {
                Console.WriteLine(item);
                if((Regex.Match(item, _usZipRegEx).Success)){
                    containsZip = true;
                    Console.WriteLine("Zip matches.");
                }
            }
            return containsZip;
        }
    }
}