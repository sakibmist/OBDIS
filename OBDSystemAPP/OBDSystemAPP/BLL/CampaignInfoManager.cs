using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.BLL
{
    public class CampaignInfoManager
    {
        private CampaignInfoGateway _campaignInfoGateway = new CampaignInfoGateway();
        public  string Save(CampaignInfo aCampaignInfo)
        {
            int rowAffected = _campaignInfoGateway.Save(aCampaignInfo);
            if (rowAffected >0)
            {
                return "success";
            }
            else
            {
                return "failed";
            }
        }

        public  List<CampaignInfo> GetAllCampaignInfo()
        {
            return _campaignInfoGateway.GetAllCampaignInfo();
        }
    }
}