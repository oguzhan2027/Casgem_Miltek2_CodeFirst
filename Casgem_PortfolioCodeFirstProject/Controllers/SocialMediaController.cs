using Casgem_PortfolioCodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Casgem_PortfolioCodeFirstProject.Controllers
{
    public class SocialMediaController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = TravelContext.SocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            List<SelectListItem> values=(from x in travelContext.Guides.ToList()
                                         select new SelectListItem
                                         {
                                             Value = x.Guide.ToString(),
                                             Text = x.GuideName
                                         }).ToList();
            ViewBag.v = values;
            return View();
        }

    }
}