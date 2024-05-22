using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa01.Controllers
{
    public class GioiThieuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BanThan()
        {
            return View("My");
        }
        public IActionResult ChaMe()
        {
            return View();
        }
        public IActionResult AnhChiEm()
        {
            return View();
        }
    }
}
