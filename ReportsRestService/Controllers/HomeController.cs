using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsRestService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string template,string parameters )
        {
         
            ViewBag.Template = template;
            ViewBag.Parameters = new Dictionary<string,object>();
            if (parameters != null)
            {

                ViewBag.Parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(parameters);
            }
            return View();
        }

        

    }
}