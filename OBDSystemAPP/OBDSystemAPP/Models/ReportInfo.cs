using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class ReportInfo
    {
        public int  Id { get; set; }
        public string  Name { get; set; }
        public string  DonorId { get; set; }
        public string  Msg { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}