using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;

namespace OBDSystemAPP.BLL
{
    public class BldOrganizationManager
    {
        private BldOrganizationGateway _bldOrganizationGateway = new BldOrganizationGateway();

        public string SaveOrganizationInfo(Models.BldOrganizationInfo aInfo)
        {
            bool isDuplicateExist =_bldOrganizationGateway.IsExist(aInfo);
            if (!isDuplicateExist)
            {
                int rowAffected = _bldOrganizationGateway.SaveOrganizationInfo(aInfo);
                if (rowAffected >0)
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

        public List<ViewModels.OrganizationDistDivisionInfo> GetOrganizationDetail()
        {
            return _bldOrganizationGateway.GetOrganizationDetail();
        }


        public  List<ViewModels.OrganizationDistDivisionInfo> GetOrganizationDetail(int   a, int  b)
        {
            return _bldOrganizationGateway.GetOrganizationDetail(a, b);
        }

        public  int GetTotalNumberOfOrganization()
        {
            return _bldOrganizationGateway.GetTotalNumberOfOrganization();
        }
    }
}