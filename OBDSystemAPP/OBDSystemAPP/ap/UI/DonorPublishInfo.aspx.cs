using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.ap.UI
{
    public partial class DonorPublishInfo : System.Web.UI.Page
    {
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
                
            if (!IsPostBack)
            {
                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx");
                }
               
            
            }
            LoadPublishDonorGridview();
        }

        private void LoadPublishDonorGridview()
        {
            string publishStatus = "publish";
            List<DonorDetailInfoForSearch> aOrganizationDistDivisionInfos = _donorInfoManager.GetDonorDetail(publishStatus) ?? new List<DonorDetailInfoForSearch>();
            PublishDonorDetailGridView.DataSource = aOrganizationDistDivisionInfos;
            PublishDonorDetailGridView.DataBind();
        }
    }
}