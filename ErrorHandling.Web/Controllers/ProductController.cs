using ErrorHandling.Web.Filter;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    [CustomHandleExceptionFilterAttribute(ErrorPage = "Error2")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            throw new FileNotFoundException();
            return View();
        }
        public IActionResult Error2()
        {
            return View();
        }
    }
}
