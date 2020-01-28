
using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet] //resposible for displaying the initial blank form
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost] //resposible for recieving submitted data and deciding what to do with it
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: store response from guest
            return View();
        }
    }
}
