using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class DistrictInfo
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int DivisionInfoId { get; set; }
    }
}