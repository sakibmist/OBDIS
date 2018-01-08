using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace OBDSystemAPP.ViewModels
{
    public class DistrictDivisionAreaInfo
    {
        public int DistrictId { get; set; } 
        public string DistrictName { get; set; }
        public string DivisionName { get; set; }

    }
}