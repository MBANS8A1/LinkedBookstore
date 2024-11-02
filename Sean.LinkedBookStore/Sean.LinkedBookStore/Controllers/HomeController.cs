using Microsoft.AspNetCore.Mvc;
namespace Sean.LinkedBookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Sean.LinkedBookStore";
        }
    }
}
