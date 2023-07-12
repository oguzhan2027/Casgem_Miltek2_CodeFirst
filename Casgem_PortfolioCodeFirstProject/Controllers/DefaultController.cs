using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_PortfolioCodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialHead()
        {
            return PartialView();
        }
        public ActionResult PartialNavbar()
        {
            return PartialView();
        }
        public ActionResult PartialSlider() 
        {
            return PartialView();
        }
        public ActionResult CallToAction()
        {
            return PartialView();
        }
        public ActionResult PartialSpecification()
        {
            return PartialView();
        }
        public ActionResult PartialCovers()
        {
            return PartialView();
        }
        public ActionResult PartialTeams()
        {
            return PartialView();
        }
        public ActionResult PartialClients()
        { 
            return PartialView();
        }
        public ActionResult PartialFooter() 
        {
            return PartialView();
        }
    }
}