using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class DonorInfo
    {

        public int Id { get; set; }
        public string  DonorName { get; set; }
        public string  DonorType { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int BloodInfoId { get; set; }
        public string   Gender { get; set; }
        public DateTime Dob { get; set; }
        public string  Mobile { get; set; }
        public string  AlterMobile { get; set; }
        public string  Email { get; set; }
        public string FacebookId { get; set; }
        public int DivisionInfoId { get; set; }
        public int DistrictInfoId { get; set; }
        public int SubDistrictInfoId { get; set; }
        public string City { get; set; }
        public string  DonorUserId { get; set; }
        public string  DonorPassword { get; set; }
        public string   AbilityToDonate { get; set; }
        public string PublishStatus { get; set; }
      
    }
}