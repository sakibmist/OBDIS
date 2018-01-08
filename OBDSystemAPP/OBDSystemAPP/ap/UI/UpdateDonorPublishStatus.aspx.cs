using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.ap.UI
{
    public partial class UpdatDonorPublishStatus : System.Web.UI.Page
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
                if (Request.QueryString["DonorId"] != null && Request.QueryString["Update"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["DonorId"]);
                    GetDataById(id);
                } 
            }
        }

        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        } 
        private void GetDataById(int id)
        {
            DonorInfo aDonorInfo = _donorInfoManager.GetDonorDataById(id);
            publishStatusDropDownList.SelectedValue = aDonorInfo.PublishStatus.ToString();
        }

        protected void UpdatePublishButton_Click(object sender, EventArgs e)
        {
            string publicStatus = publishStatusDropDownList.Text;

            if (!string.IsNullOrEmpty(publicStatus) && Request.QueryString["DonorId"] != null)
            {

                DonorInfo aDonorInfo  = new DonorInfo();
                int id = Convert.ToInt32(Request.QueryString["DonorId"]);
                aDonorInfo .Id = id;
                aDonorInfo.PublishStatus  = publicStatus; 

                string msg = _donorInfoManager.UpdatePublishInfo(aDonorInfo);
                if (msg == "update")
                {
                    DisplayMessage("Updated Successfully", Color.ForestGreen);

                }
                else if (msg == "failed")
                {
                    DisplayMessage("Update data failed.", Color.ForestGreen);
                }
                else if (msg == "exist")
                {
                    DisplayMessage("Duplicate Data Required! Same Division Name Exist.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again", Color.Red);
            }
        }
    }
}