using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4411031254.Controllers
{
    public class waterController : Controller
    {
        // GET: water
        public ActionResult Index(string name, float? weight)
        {
            var result = "";//预设为空
            if (weight.HasValue)//判断有无输入
            {
                result = (weight * 30) + "cc"; //根据体重*30之后加单位
            }
            //将数值显示
            ViewBag.name = name;
            ViewBag.Result = result;

            return View();
        }
    }
}