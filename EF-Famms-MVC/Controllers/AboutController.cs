using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Famms_MVC.Controllers
{
    public class AboutController : Controller
    {
             public ActionResult Index()
        {
            return View();
        }
       
    }
}
