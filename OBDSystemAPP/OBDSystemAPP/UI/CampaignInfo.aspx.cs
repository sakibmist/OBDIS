using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;

namespace OBDSystemAPP.UI
{
    public partial class CampaignInfo : System.Web.UI.Page
    {
        private CampaignInfoManager _campaignInfoManager = new CampaignInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               /* string[] filePaths = Directory.GetFiles(Server.MapPath("~/ImageBox/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    string fileName = Path.GetFileName(filePath);
                    files.Add(new ListItem(fileName, "~/ImageBox/" + fileName));
                }*/
                LoadCampaignInfo();
            }
           
        }

        private void LoadCampaignInfo()
        {
            List<Models.CampaignInfo> aCampaignInfos =_campaignInfoManager .GetAllCampaignInfo()?? new List<Models.CampaignInfo>();
            CampainInfoDataList.DataSource = aCampaignInfos;
            CampainInfoDataList.DataBind();
        }
    }
}