using EF_Famms_MVC.Controllers;
using EF_Famms_MVC.Models;
using EF_Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Famms_MVC.ViewComponents
{
    public class FooterContactViewComponent : ViewComponent
    {
        private readonly FammsDbContext _context;
        public FooterContactViewComponent(FammsDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerContacts = _context.FooterContacts.ToList();
            var model = new FooterContactVM
            {
                FooterContacts = footerContacts
            };
            return View(model);
        }

    }


}

