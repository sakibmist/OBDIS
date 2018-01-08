using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class BldOrganizationInfo
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int DivisionInfoId { get; set; }
        public int DistrictInfoId { get; set; }
      /*  public DateTime  CreatedAt { get; set; }*/
    }
}