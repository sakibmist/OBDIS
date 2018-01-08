using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using OBDSystemAPP.BLL;
using OBDSystemAPP.DAL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.Services
{
    // <summary>
    // Summary description for AjaxHandlerServerWork
    // </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
   // [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     //[System.Web.Script.Services.ScriptService]
  /*  public class AjaxHandlerServerWork : System.Web.Services.WebService
    {
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        SubDistrictInfoManager _subDistrictInfoManager=new SubDistrictInfoManager();
       // private DistrictInfoGateway _districtInfoGateway = new DistrictInfoGateway();
        [WebMethod]
        public string GetAllDistricts( string divisionId)    //jason strinify kore string data server e send kore.
        {
            string output = "";
            if (!string .IsNullOrEmpty(divisionId))
            {
                int division = Convert.ToInt32(divisionId);
                List<DistrictInfo> aDistrictInfos = _districtInfoManager.GetAllDistrictName(division);
                JavaScriptSerializer js=new JavaScriptSerializer();
                output = js.Serialize(aDistrictInfos);
               
                return output;
            }
            return output;
        }

        [WebMethod]
        public string GetAllSubDistricts(string districtId)
        {
            string responses = "";
            if (!string.IsNullOrEmpty(districtId))
            {
                int district = Convert.ToInt32(districtId);
                List<SubDistrictInfo> aSubDistrictInfos=_subDistrictInfoManager.GetAllSubDistrict(district);
                JavaScriptSerializer js = new JavaScriptSerializer();
                responses = js.Serialize(aSubDistrictInfos);
                return responses;
            }
            return responses;
        }
      /*  [WebMethod]
        public string DistrictNameExist(string districtName)
        {
            string responses = "";
            if (!string.IsNullOrEmpty(districtName))
            {

                bool isDistrictNameExist = _districtInfoGateway.IsDistrictNameExist(districtName);
                /*if (!isDistrictNameExist)
                {
                    return ""
                }#2#
                JavaScriptSerializer js = new JavaScriptSerializer();
                responses = js.Serialize(isDistrictNameExist);
                return responses;
            }
            return responses;
        }#1#

    }*/
}
