using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CoreTest.Models;

namespace CoreTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Photos()
        {
            ViewData["Message"] = "Here are some photos";

            Gallery MyPictures = new Gallery()
            {
                name = "My Photos",
                Photos = new Photo[]
                {
                    new Photo
                    {
                        id = 1,
                        name = "Image One",
                        caption = "A lovely image, hand picked by me.",
                    },
                    new Photo
                    {
                        id = 2,
                        name = "Image Two",
                        caption = "Another lovely image, hand picked by me.",
                    },
                    new Photo
                    {
                        id = 3,
                        name = "Image Three",
                        caption = "Here's another lovely image, hand picked by me.",
                    },
                    new Photo
                    {
                        id = 4,
                        name = "Image Four",
                        caption = "And even another lovely image, hand picked by me.",
                    }
                }
            };
            return View(MyPictures);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
