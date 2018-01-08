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
    public partial class bloodInfo : System.Web.UI.Page
    {
        private BloodInfoManager _bloodInfoManager=new BloodInfoManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx");
                }

            }

        }


        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void bloodGroupSaveButton_Click(object sender, EventArgs e)
        {
            string a = bloodGroupNameTextBox.Text.Trim();
            if (!String.IsNullOrEmpty(a))
            {
                BloodInfo aBloodInfo = new BloodInfo();
                aBloodInfo.BloodGroupName = a;
                string msg = _bloodInfoManager.SaveBloodGroup(aBloodInfo);
                if (msg == "success")
                {
                    DisplayMessage("Save Successfully.", Color.ForestGreen);
                     Response .Redirect("showBloodInfo.aspx");
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Failed! Try Again.", Color.DarkRed);

                }
                else if (msg == "exist")
                {
                    DisplayMessage("Duplicate BloodGroup Exist! Try Again.", Color.DarkRed);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.Red);
            }
           
            
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            bloodGroupNameTextBox.Text = null;
            InfoMessageLabel.Text = null;
        }
    }
}