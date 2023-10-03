using Microsoft.AspNetCore.Mvc.Rendering;
using PartyInvites.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    //GuestResponse Class
    //In the GuestResponse Class, properties such as Name, Email, Phone and validation
    //is added for each property.
    public class GuestResponse
    {
        //Name property
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        //Email property
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        //Phone property
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        //WillAttend Property
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }

        //TechnicalInterest Enum property
        [Required(ErrorMessage = "Please specify your technical interest")]
        public TechnicalInterest TechnicalInterest { get; set; }

    }
}
