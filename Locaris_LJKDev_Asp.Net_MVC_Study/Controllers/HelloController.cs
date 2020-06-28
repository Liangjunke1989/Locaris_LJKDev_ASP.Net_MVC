using System.Web.Mvc;
using Locaris_LJKDev_Asp.Net_MVC_Study.Models;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Say()
        {
            return Content("aaa");      //返回纯文本
        }
        public ActionResult RedirectTest()
        {
            return Redirect(Url.Action("LjkAction","LJK"));
        }
        //异步请求
        public ActionResult JsonTest()
        {
            Person person=new Person()
            {
                Age = "30", 
                QQ = "123654"
            };
            return Json(person,JsonRequestBehavior.AllowGet);        //转成Json对象
        }
        //第一种方式：Request["键"]的方式接收参数
        [System.Web.Mvc.HttpGet]
        public ActionResult Add()
        {
            int id = int.Parse(Request["id"]);
            ViewBag.Id = id;
            return View();
        }

        //第二种方式：自动装配
        //如果要实现行为的重载，要满足两个条件：1.参数不同（签名不同）2.请求类型不同
        [System.Web.Mvc.HttpPost]                 //自动装配
        public ActionResult Add(int txtId)   
        {
            ViewBag.Id2 = txtId;
            return View();
        }
    }
}