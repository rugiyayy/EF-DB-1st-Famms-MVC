using EF_Famms_MVC.Models;
using EF_Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Famms_MVC.Controllers
{
    public class TestimonialController : Controller
    {

        private readonly FammsDbContext _context;

        public TestimonialController(FammsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var testimonials = _context.Testimonials.ToList();

            var model = new TestimonialIndexVM

            {
                Testimonials = testimonials


            };
            return View(model);

        }
    }
}
