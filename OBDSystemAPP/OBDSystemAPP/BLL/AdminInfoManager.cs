using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using OBDSystemAPP.DAL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.BLL
{
    public class AdminInfoManager
    {
        AdminInfoGateway _adminInfoGateway=new AdminInfoGateway();
        public  string Save(AdminInfo aadminInfo)
        { 
            bool isExistData = _adminInfoGateway.IsDuplicat(aadminInfo);
            if (!isExistData)
            {
                int rowAffected = _adminInfoGateway.Save(aadminInfo);
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

        public  string IsExist(string a, string b)
        {
            bool isMatch = _adminInfoGateway.IsMatch(a,b);
            if (isMatch)
            {
                return "success";
            }
            else
            {
                return "failed";
            }
        } 

        public AdminInfo GetAllInfo(string  adminId)
        {
            return _adminInfoGateway.GetAllInfo(adminId);
        }



        public  List<AdminInfo> GetAllAdminInfo(string adId)
        {
            return _adminInfoGateway.GetAllAdminInfo(adId);
        }
    }
}