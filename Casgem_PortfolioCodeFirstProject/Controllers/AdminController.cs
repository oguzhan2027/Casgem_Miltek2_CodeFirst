using Casgem_PortfolioCodeFirstProject.DAL.Context;
using Casgem_PortfolioCodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_PortfolioCodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
       
    }
}