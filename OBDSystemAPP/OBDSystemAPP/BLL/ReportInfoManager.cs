using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;

namespace OBDSystemAPP.BLL
{
    public class ReportInfoManager
    {
        private ReportInfoGateway _reportInfoGateway = new ReportInfoGateway();
        public  string SaveReportInfo(Models.ReportInfo aReportInfo)
        {
            int rowAffected = _reportInfoGateway.SaveReportInfo(aReportInfo);
            if (rowAffected>0)
            {
                return "success";
            }
            else
            {
                return "failed";
            }
        }

        public  List<Models.ReportInfo> GetAllReportInfo()
        {
            return _reportInfoGateway.GetAllReportInfo();
        }

        public  int GetNumberOfMsg()
        {
            return _reportInfoGateway.GetNumberOfMsg();
        }

        public  string DeleteDivisionById(int id)
        {
            int rowAffected = _reportInfoGateway.DeleteDivisionById(id);
            if (rowAffected > 0)
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