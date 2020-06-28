using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Locaris_LJKDev_Asp.Net_MVC_Study.Models;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Controllers
{
    public class LJKController : Controller
    {
        // GET: LJK
        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult LjkAction()
        {
            return View();
        }

        public ActionResult HtmlTest()
        {
            ViewData["LJK"] = "123";
            ViewBag.Junke = "455";

            List<SelectListItem> listItems=new List<SelectListItem>();
            listItems.Add(new SelectListItem()
            {
                Selected = false,
                Text = "LJK_01",
                Value = "010203"
            });
            listItems.Add(new SelectListItem()
            {
                Selected = false,
                Text = "LJK_02",
                Value = "040506"
            });
            listItems.Add(new SelectListItem()
            {
                Selected = false,
                Text = "LJK_02",
                Value = "070809"
            });
            ViewData["LJKList"] = listItems;
            
            ViewData.Model=new Person()
            {
                Age = "10",
                QQ = "123456"
            };
            return View();
        }
        

        [System.Web.Http.HttpPost]
        public ActionResult Add(int txtId)
        {
            ViewBag.Id2 = txtId;
            return View();
        }
    }
}