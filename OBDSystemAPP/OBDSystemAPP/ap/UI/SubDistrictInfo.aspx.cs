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
    public partial class SubDistrictInfo : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        private SubDistrictInfoManager _subDistrictInfoManager = new SubDistrictInfoManager();
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
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
            divisionNameDropDownList.Items.Insert(0, new ListItem("Select One", ""));

        }
       
        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
       

        protected void subdistrictNameSaveButton_Click(object sender, EventArgs e)
        {
            string a = subDistrictNameTextBox.Text.Trim();
            string b = districtNameDropDownList.SelectedValue;
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                Models.SubDistrictInfo aSubDistrictInfo = new Models.SubDistrictInfo();
                aSubDistrictInfo.SubDistrictName = a;
                aSubDistrictInfo.DistrictInfoId = Convert.ToInt32(b);
                string msg = _subDistrictInfoManager.SaveSubDistrictInfo(aSubDistrictInfo); 
                if (msg == "success")
                {
                    DisplayMessage("Save Successfully", Color.ForestGreen);
                    
                     Response.Redirect("SubDistrictGridView.aspx");
                    
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Failed! Try Again.", Color.Red);
                }
               /* else if (msg == "exist")
                {
                    DisplayMessage("Duplicate Data Exist! Try Again.", Color.Red);
                }*/
            }
            else
            {
                DisplayMessage("Empty Fields Are Required!", Color.Red);
            }
           

        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            districtNameDropDownList.Text = null;
            subDistrictNameTextBox.Text = null;
            InfoMessageLabel.Text = null;
            
        }

        protected void divisionNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var divisionId = divisionNameDropDownList.SelectedValue;
            int aDivisionId = Convert.ToInt32(divisionId);
            List<Models.DistrictInfo> aDistrictInfos = _districtInfoManager.GetAllDistrict(aDivisionId) ?? new List<Models.DistrictInfo>();
            districtNameDropDownList.DataSource = aDistrictInfos;
            districtNameDropDownList.DataValueField = "Id";
            districtNameDropDownList.DataTextField = "DistrictName";
            districtNameDropDownList.DataBind();
            districtNameDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }
    }
}