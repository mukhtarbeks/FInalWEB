using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp.WEB.Models
{
    public enum Status { Done, Processing,Rejected }
    public class Detail
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public Status Status { get; set; }
    }
}