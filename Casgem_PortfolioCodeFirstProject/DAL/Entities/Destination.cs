using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_PortfolioCodeFirstProject.DAL.Entities
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string DestinaitonName { get; set; }
        public string DayNight { get; set; }
        public byte Capacity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}