using EF_Famms_MVC.Models;
using EF_Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EF_Famms_MVC.Controllers
{
	public class HomeController : Controller
	{
        private readonly FammsDbContext _context;

        public HomeController(FammsDbContext context)
        {
			_context=context;
        }
        public IActionResult Index()
		{
			var products= _context.ProductsTbls.ToList();
            var testimonials =_context.Testimonials.ToList();

			var model = new HomeIndexVM

			{
				ProductsTbls = products,
				Testimonials = testimonials


            };
            return View(model);

		}

		//[HttpGet]
		//public async Task<IActionResult> GetProducts()
		//{
  //          return Ok(await _context.ProductsTbls.ToListAsync());
		//}

	}
}