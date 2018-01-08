using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.ap.UI
{
    public partial class IndexLogin : System.Web.UI.Page
    {
        private AdminInfoManager _adminInfoManager = new AdminInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
           string a = adminIdTextBox.Text.Trim();
           string b = passwordTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(a)&& !string.IsNullOrEmpty(b))
            {
                AdminInfo bAdminInfo = new AdminInfo();
                bAdminInfo.AdminId = a;
                bAdminInfo.Passwords = b; 
                string msg=_adminInfoManager.IsExist( a, b);
                
                if (msg=="success")
                {
                    Session["adminId"] = bAdminInfo.AdminId;
                    Response.Redirect("DashboardFirstForm.aspx");
                    InfoMessageLabel.Text = null; 

                }
                else if(msg=="failed")
                {
                    DisplayMessage("Invalid UserId Or Password! Try Again.",Color.Red );
                }

            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.",Color.Red );
            }
           



        }
    }
}