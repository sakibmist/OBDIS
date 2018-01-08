using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class SubDistrictInfo
    {
        public int Id { get; set; }
        public string SubDistrictName { get; set; }
        public int DistrictInfoId { get; set; }
        
    }
}