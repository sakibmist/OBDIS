using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.ap.UI
{
    public partial class DonorDetailInfo : System.Web.UI.Page
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
                if (Request.QueryString["DonorId"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["DonorId"]);
                    DeleteDataById(id);

                }
                 
               
            }

            LoadDonorDetailInfo();
            
        }

        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        private void DeleteDataById(int id)
        {
            string msg = _donorInfoManager.DeleteById(id);
            if (msg == "delete")
            {
                DisplayMessage("Remove Successfully.", Color.ForestGreen); 
            }
            else if (msg == "failed")
            {
                DisplayMessage("Failed! Try Again.", Color.Red);

            }
        } 

        private void LoadDonorDetailInfo()
        {
            string publishStatus = "unpublish";
            List<DonorDetailInfoForSearch> aOrganizationDistDivisionInfos = _donorInfoManager.GetDonorDetail(publishStatus) ?? new List<DonorDetailInfoForSearch>();
            DonorDetailGridView.DataSource = aOrganizationDistDivisionInfos;
            DonorDetailGridView.DataBind();
        }
    }
}