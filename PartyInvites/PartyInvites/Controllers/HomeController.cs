using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

//The HomeController.cs controller contains RsvpForm ViewResults, which represents the
// functionality of Accept Invitation and Send Regrets buttons which are located 
// in the RsvpForm.cshtml file.

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
            
        }

        }
}