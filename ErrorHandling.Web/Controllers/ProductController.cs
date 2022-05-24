using ErrorHandling.Web.Filter;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            throw new FileNotFoundException();
            return View();
        }

    }
}
