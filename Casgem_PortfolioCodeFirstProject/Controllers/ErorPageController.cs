using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_PortfolioCodeFirstProject.Controllers
{
    public class ErorPageController : Controller
    {
        // GET: ErorPage
        public ActionResult Page404()
        {
            return View();
        }
    }
}