using Casgem_PortfolioCodeFirstProject.DAL.Context;
using Casgem_PortfolioCodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_PortfolioCodeFirstProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        TravelContext travelContext = new TravelContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Admin admin)
        {
            var values = travelContext.Admins.FirstOrDefault(x=> x.UserName == admin.UserName && x.Password == admin.Password);
            
            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["userTravel"] = values.UserName.ToString();
                return RedirectToAction("Index", "AdminGuide");

            }
            return View();
        }
    }
}