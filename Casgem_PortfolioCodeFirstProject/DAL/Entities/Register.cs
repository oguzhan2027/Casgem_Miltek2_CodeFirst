using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_PortfolioCodeFirstProject.DAL.Entities
{
    public class Register

    {
        public int RegisterID { get; set; }
        public string RegisterUserName { get; set; }
        public string RegisterMail { get; set; }
        public string RegisterContactNumber { get; set; }
        public string RegisterPassword { get; set; }
    }
}