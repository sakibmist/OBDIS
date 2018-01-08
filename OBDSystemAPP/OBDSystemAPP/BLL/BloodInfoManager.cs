using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.BLL
{
    public class BloodInfoManager
    {
        BloodInfoGateway _bloodInfoGateway=new BloodInfoGateway();
        public string SaveBloodGroup(BloodInfo aBloodInfo)
        {
            bool isDuplicateBloodGroup = _bloodInfoGateway.IsDuplicatBldGroup(aBloodInfo);
            if (!isDuplicateBloodGroup)
            {
                int rowAffected = _bloodInfoGateway.SaveBloodGroup(aBloodInfo);
                if (rowAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                } 
            }
            else
            {
                return "exist";
            }
           
        }

        public List<BloodInfo> GetAllBloodGroup()
        {
            return _bloodInfoGateway.GetAllBloodGroup();
        }

        public  string DeleteBloodGroup(int id)
        {
            int rowAffected = _bloodInfoGateway.DeleteBloodGroup(id);
            if (rowAffected >0)
            {
                return "deleted";
            }
            else
            {
                return "failed";
            }
        }
    }
}