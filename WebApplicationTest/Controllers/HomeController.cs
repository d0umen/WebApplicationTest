using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Rectangle> Rectangles { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.Rectangles = new List<Rectangle>();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult First()
        {
            return View();
        }
        [HttpPost]
        public IActionResult First(int countRectangle)
        {
            if (countRectangle > 0)
            {
                ViewBag.Count = countRectangle;
            }

            for (int i = 0; i < countRectangle; i++)
            {
                this.Rectangles.Add(new Rectangle() { Name = "rect" + i.ToString()});
            }
            
            return View();
        }
        //[HttpGet]
        //public IActionResult First()
        //{
        //    //string n = String.Format("{0}", Request.Form["rect0h"]);
        //    return View();
        //}
    }
}