using EF_Famms_MVC.Areas.Admin.ViewModels;
using EF_Famms_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EF_Famms_MVC.Areas.Admin.Controllers
{
    public class ContactController : BaseController
    {
        private readonly FammsDbContext _context;

        public ContactController(FammsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var queries = _context.Queries.ToList();

            var model = new ContactIndexVM
            {
                 Queries= queries
            };

            return View(model);
        }
    }
}
