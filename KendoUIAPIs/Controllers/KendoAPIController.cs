using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoUIAPIs.Dtos;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using System.Text;

namespace KendoUIAPIs.Controllers
{
    public class KendoAPIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GridInlineEditing()
        {
            return View();
        }

        public ActionResult GridMVVM()
        {
            return View();
        }

        public ActionResult MasterDetailGrid()
        {
            return View();
        }

        public ActionResult SignalR()
        {
            return View();
        }

        public ActionResult Main()
        {

            return File("~/Views/KendoAPI/Main.html", "text/html");
        }

        public ActionResult DetailTemplate()
        {
            return File("~/Views/KendoAPI/Templates/detail.tmpl.html", "text/html");
        }

        public ActionResult IndexTemplate()
        {
            return File("~/Views/KendoAPI/Templates/index.tmpl.html", "text/html");
        }

        public ActionResult View3Template()
        {
            return File("~/Views/KendoAPI/Templates/view3.tmpl.html", "text/html");
        }

        public ActionResult SPATemplates()
        {
            StringBuilder htmlContent = new StringBuilder();

            htmlContent.Append(System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/Views/KendoAPI/Templates/detail.tmpl.html")));
            htmlContent.Append(System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/Views/KendoAPI/Templates/index.tmpl.html")));
            htmlContent.Append(System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/Views/KendoAPI/Templates/view3.tmpl.html")));

            return Content(htmlContent.ToString());
        }

        public ActionResult KendoApp()
        {
            return View();
        }
    }
}
