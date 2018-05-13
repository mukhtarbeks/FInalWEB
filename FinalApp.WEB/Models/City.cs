using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp.WEB.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}