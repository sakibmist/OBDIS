using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.ViewModels
{
    public class OrganizationDistDivisionInfo
    {
        public int BldOrganizationInfoId { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string DistrictName { get; set; }
        public string  DivisionName { get; set; } 
        public DateTime  CreatedAt { get; set; }
    }
}