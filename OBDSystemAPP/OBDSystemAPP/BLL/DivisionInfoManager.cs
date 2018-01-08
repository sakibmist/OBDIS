using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;

namespace OBDSystemAPP.BLL
{
    public class DivisionInfoManager
    {
        private DivisionInfoGateway _divisionInfoGateway = new DivisionInfoGateway();
        private DistrictInfoGateway _districtInfoGateway = new DistrictInfoGateway();
        public string SaveDivisionName(DivisionInfo aDivisionInfo)
        {
            bool isDivisionNameExist = _divisionInfoGateway.IsDivisionNameExist(aDivisionInfo);
            if (!isDivisionNameExist)
            {
                int rowAffected = _divisionInfoGateway.SaveDivisionName(aDivisionInfo);
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

        public List<DivisionInfo> GetAllDivision()
        {
            return _divisionInfoGateway.GetAllDivision();
        }

        public string DeleteDivisionById(int id)
        {
            int rowAffected = _divisionInfoGateway.DeleteDivisionById(id);
            if (rowAffected > 0)
            {
                return "deleted";
            }
            else
            {
                return "failed";
            }
        }





        public DivisionInfo GetDataById(int id)
        {
            return _divisionInfoGateway.GetDivisionDataById(id);
        }

        public string UpdateDivisionInfo(DivisionInfo aDivisionInfo)
        {
            bool isDivisionNameExist = _divisionInfoGateway.IsDivisionNameExist(aDivisionInfo);
            if (!isDivisionNameExist)
            {
                int rowAffected = _divisionInfoGateway.UpdateDivisionInfo(aDivisionInfo);
                if (rowAffected > 0)
                {
                    return "update";
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
    }
}