using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;
 


namespace OBDSystemAPP.ap.UI
{
    public partial class DivisionInfo : System.Web.UI.Page
    {
       DivisionInfoManager _divisionInfoManager=new DivisionInfoManager();
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
      

        private  void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }

        protected void divisionNameSaveButton_Click1(object sender, EventArgs e)
        {
            string a = divisionNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(a))
            {
                Models.DivisionInfo aDivisionInfo = new Models.DivisionInfo();
                aDivisionInfo.DivisionName = a;
                string msg = _divisionInfoManager.SaveDivisionName(aDivisionInfo);
                
                if (msg == "success")
                {
                    DisplayMessage("Save Successfully.", Color.ForestGreen);
                  
                    Response .Redirect("AllDivisions.aspx");
                    
                    
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Failed! Try Again.", Color.Red);

                }
                else if (msg =="exist")
                {
                    DisplayMessage("Duplicate Data Exist! Try Again.", Color.Red);
                }
                
            }
            else
            {
                DisplayMessage("Empty Fields Are Required!", Color .Red );
            }
          
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            divisionNameTextBox.Text = null;
            InfoMessageLabel.Text = null;
          
        } 
        
    }
}