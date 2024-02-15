using ReportsRestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsRestService.Controllers
{
    public class ExamplesController : Controller
    {
        private IExampleRepository repository;
        public ExamplesController() 
        {
            repository = new StaticRepository(); 
        }

        // GET: Exaples
        public ActionResult Index()
        {
            var catalog = repository.Catalog;
            return View(catalog);
        }
    }
}