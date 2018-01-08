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

namespace OBDSystemAPP.UI
{
    public partial class Login : System.Web.UI.Page
    {
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void loginButton_Click(object sender, EventArgs e)
        {
            string a = donorIdTextBox.Text;
            string b = passwordTextBox.Text;
           
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
              /*  List<DonorInfo > aDonorInfos = _donorInfoManager.GetAllDonorInfo(a, b) ?? new List<DonorInfo>();*/
                DonorInfo aDonorInfo = new DonorInfo();
                aDonorInfo.DonorUserId = a;
                aDonorInfo.DonorPassword = b;
               
                string msg = _donorInfoManager.IsMatch(a, b);
                if (msg=="success")
                {
                    Session["DonorUserId"] = aDonorInfo.DonorUserId;
                    Session["DonorPassword"] = aDonorInfo.DonorPassword;
                    Response.Redirect("DonorProfile.aspx");
                    InfoMessageLabel.Text = null; 
                }
                else if(msg=="failed")
                {
                    DisplayMessage("Invalid UserId Or Password! Try Again.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.Red);
            }
        }
    }
}