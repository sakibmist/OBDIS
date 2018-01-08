using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;

namespace OBDSystemAPP.BLL
{
    public class DistrictInfoManager
    {
        private DistrictInfoGateway _districtInfoGateway = new DistrictInfoGateway();

        public string SaveDistrictName(DistrictInfo aDistrictInfo)
        {
            bool isDuplicateExist = _districtInfoGateway.IsDistrictNameExist(aDistrictInfo);
            if (!isDuplicateExist)
            {
                int rowAffected = _districtInfoGateway.SaveDistrictName(aDistrictInfo);
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

        public List<DistrictInfo> GetAllDistrictName()
        {
            return _districtInfoGateway.GetAllDistrictName();
        }

        

        public List<ViewModels.DistrictDivisionAreaInfo> GetAllDistrictDivisionInfo()
        {
            return _districtInfoGateway.GetAllDistrictDivisionInfo();
        }

        public string DeleteDistrict(int id)
        {
            int rowAffected = _districtInfoGateway.DeleteDistrict(id);
            if (rowAffected > 0)
            {
                return "deleted";
            }
            else
            {
                return "failed";
            }
        }


        public List<DistrictInfo> GetAllDistrict()
        {
            return _districtInfoGateway.GetAllDistrictName();
        }

        public List<DistrictInfo> GetAllDistrict(int aDivisionId)
        {
            return _districtInfoGateway.GetAllDistrictName(aDivisionId);
        }



        
    }
}