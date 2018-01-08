using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;

namespace OBDSystemAPP.BLL
{
    public class SubDistrictInfoManager
    {
        private SubDistrictInfoGateway _subDistrictInfoGateway = new SubDistrictInfoGateway();

        public string SaveSubDistrictInfo(SubDistrictInfo aSubDistrictInfo)
        {
           /* bool isDuplicateExist = _subDistrictInfoGateway.IsDuplicateDataExist(aSubDistrictInfo);*/
           /* if (!isDuplicateExist)*/
            {
                int rowAffected = _subDistrictInfoGateway.SaveSubDistrictInfo(aSubDistrictInfo);
                if (rowAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
           /* else
            {
                return "exist";
            }*/

        }

       /* public List<SubDistrictInfo> GetAllSubDistrict(int district)
        {
            return _subDistrictInfoGateway.GetAllSubDistrict(district);
        }*/

        public List<ViewModels.SubDisDistrictDivisionInfo> GetAllAreaInfo()
        {
            return _subDistrictInfoGateway.GetAllAreaInfo();
        }



        public string DeleteSubDistrict(int id)
        {
            int rowAffected = _subDistrictInfoGateway.DeleteSubDistrict(id);
            if (rowAffected > 0)
            {
                return "deleted";
            }
            else
            {
                return "failed";
            }
        }

        public  List<SubDistrictInfo> GetAllDistrict()
        {
            return _subDistrictInfoGateway.GetAllSubDistrict();
        }

        public List<SubDistrictInfo> GetAllDistrict(int aDistrictId)
        {
            return _subDistrictInfoGateway.GetAllSubDistrict(aDistrictId);
        }
    }
}