using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhHoa01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MinhHoa01.Controllers
{

    public class RegisterController : Controller
    {
        private IHostingEnvironment hosting;
        public RegisterController(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult XuLy(PersonModel dk, IFormFile FHinh)
        {
            if(FHinh != null)
            {
                //xử lý upload
                //string filename = FHinh.FileName;
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);//tạo dãy số ramdom tránh trùng lặp
                string path = Path.Combine(hosting.WebRootPath, "images");
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    //sao chép lên server
                    FHinh.CopyTo(filestream);
                }
                dk.Picture = filename;
            }
            return View(dk);
        }
    }
}
