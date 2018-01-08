using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.ap.UI
{
    public partial class DistrictInfo : System.Web.UI.Page
    {
        DistrictInfoManager _districtInfoManager=new DistrictInfoManager();
       DivisionInfoManager _divisionInfoManager=new DivisionInfoManager(); 
        protected void Page_Load(object sender, EventArgs e)
       {
           if (!IsPostBack)
           {
              
                   if (Session["adminId"] == null)
                   {
                       Response.Redirect("IndexLogin.aspx");
                   }
                
               

               
               LoadDivisionDropdown();
           }
           
       }

        

        private void LoadDivisionDropdown()
        {
             
            List<Models.DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<Models.DivisionInfo>();
            divisionNameDropDownList.DataSource = aDivisionInfos;
            divisionNameDropDownList.DataValueField = "Id";
            divisionNameDropDownList.DataTextField = "DivisionName";
            divisionNameDropDownList.DataBind();
            divisionNameDropDownList.Items .Insert(0,new ListItem("Select One",""));

        }

        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        
        protected void districtNameSaveButton_Click(object sender, EventArgs e)
        {
            string a=districtNameTextBox.Text.Trim();
            string b = divisionNameDropDownList.SelectedValue;
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                Models.DistrictInfo aDistrictInfo = new Models.DistrictInfo();
                aDistrictInfo.DistrictName = a;
                aDistrictInfo.DivisionInfoId = Convert.ToInt32(b);

                string msg = _districtInfoManager.SaveDistrictName(aDistrictInfo);
                
                if (msg == "success")
                {
                    DisplayMessage("Save Successfully.", Color.ForestGreen); 
                    Response.Redirect("AllDistrictInfo.aspx");
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Failed! Try Again.", Color.DarkRed);

                }else if (msg=="exist")
                {
                    DisplayMessage("Duplicate Data Exist! Try Again.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required!",Color.Red );
            }
            
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            districtNameTextBox.Text = null;
            divisionNameDropDownList.Text = null;
            InfoMessageLabel.Text = null;
            
        }
    }
}