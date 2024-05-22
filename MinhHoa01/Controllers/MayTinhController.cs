using Microsoft.AspNetCore.Mvc;
using MinhHoa01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa01.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Minh hoạ 1: tiếp nhận tham số thông qua Request (truyền thống)
        //public IActionResult XuLy() {

        //    //b1.lấy giá trị các tham số (So1, So2, PhepTinh)
        //    var x = double.Parse(Request.Form["So1"]);
        //    var y = double.Parse(Request.Form["So2"]);
        //    var op = Request.Form["PhepTinh"];
        //    //b2. tính toán kết quả
        //    double ketqua=0;
        //    switch (op)
        //    {
        //        case "+": ketqua = x + y; break;
        //        case "-": ketqua = x - y; break;
        //        case "*": ketqua = x * y; break;
        //        case "/": ketqua = x / y; break;
        //    }
        //    //b3.Trả kêt quả về người dùng
        //    ViewData["KQ"] = ketqua; //truyền dữ liệu cho view thông qua ViewData
        //    ViewBag.KQ = ketqua; //truyền dữ liệu cho view thông qua ViewBag
        //    return View();
        //}

        ////Minh hoạ 2: tiếp nhận tham số thông qua đối số của action
        //public IActionResult XuLy(double So1, double So2, string PhepTinh)
        //{
        //    //b1.lấy giá trị các tham số (So1, So2, PhepTinh)
        //    //b2. tính toán kết quả 
        //    double ketqua = 0;
        //    switch (PhepTinh)
        //    {
        //        case "+": ketqua = So1 + So2; break;
        //        case "-": ketqua = So1 - So2; break;
        //        case "*": ketqua = So1 * So2; break;
        //        case "/": ketqua = So1 / So2; break;
        //    }
        //    //b3.Trả kêt quả về người dùng
        //   // ViewData["KQ"] = ketqua; //truyền dữ liệu cho view thông qua ViewData
        //    ViewBag.KQ = ketqua; //truyền dữ liệu cho view thông qua ViewBag
        //    return View();
        //}

        //Minh hoạ 3: tiếp nhận tham số thông qua model
        public IActionResult XuLy(MayTinhModel mt)
        {
            ////b1.lấy giá trị các tham số (So1, So2, PhepTinh)
            ////b2. tính toán kết quả
            //double ketqua = 0;
            //switch (mt.PhepTinh)
            //{
            //    case "+": ketqua = mt.So1 + mt.So2; break;
            //    case "-": ketqua = mt.So1 - mt.So2; break;
            //    case "*": ketqua = mt.So1 * mt.So2; break;
            //    case "/": ketqua = mt.So1 / mt.So2; break;
            //}
            ////b3.Trả kêt quả về người dùng
            //// ViewData["KQ"] = ketqua; //truyền dữ liệu cho view thông qua ViewData
            //ViewBag.KQ = mt.KetQua(); //truyền dữ liệu cho view thông qua ViewBag
            return View("Index",mt);
        }

    }
}
