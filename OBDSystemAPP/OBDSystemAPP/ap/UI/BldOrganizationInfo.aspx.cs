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
    public partial class BldOrganizationInfo : System.Web.UI.Page
    {
        private BldOrganizationManager _bldOrganizationManager = new BldOrganizationManager();
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
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
        protected void OrganizationSaveButton_Click(object sender, EventArgs e)
        {
            string a = organizationNameTextBox.Text.Trim();
            string b = addressTextBox.Text.Trim();
            string c = mobileTextBox.Text.Trim();
            string d = emailTextBox.Text.Trim();
            string es = divisionNameDropDownList.SelectedValue;
            string f = districtNameDropDownList.SelectedValue;
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c) && !string.IsNullOrEmpty(es) && !string.IsNullOrEmpty(f))
            {
                Models.BldOrganizationInfo aInfo = new Models.BldOrganizationInfo();
                aInfo.OrganizationName = a;
                aInfo.Address = b;
                aInfo.Mobile = c;
                aInfo.Email = d;
                aInfo.DivisionInfoId = Convert .ToInt32(es);
                aInfo.DistrictInfoId = Convert .ToInt32(f);
                string msg = _bldOrganizationManager.SaveOrganizationInfo(aInfo);
                if (msg == "success")
                {
                   
                    DisplayMessage("Save Successfully.", Color.ForestGreen);
                    

                }
                else if (msg == "failed")
                {
                    DisplayMessage("Failed! Try Again.", Color.DarkRed);

                }
                else if (msg == "exist")
                {
                    DisplayMessage("Duplicate Data Exist! Try Again.", Color.Red);
                }

            }
            else
            {
                DisplayMessage("Empty Fields Are Required!", Color.Red);
            }
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            organizationNameTextBox.Text = null;
            addressTextBox.Text = null;
            mobileTextBox.Text = null;
            emailTextBox.Text = null;
            divisionNameDropDownList.Text = null;
            districtNameDropDownList.Text = null;
            InfoMessageLabel.Text = null;
            
        }

        protected void divisionNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var divisionId = divisionNameDropDownList.SelectedValue;
            int aDivisionId = Convert.ToInt32(divisionId);
            List<Models.DistrictInfo> aDistrictInfos = _districtInfoManager.GetAllDistrict(aDivisionId ) ?? new List<Models.DistrictInfo>();
            districtNameDropDownList.DataSource = aDistrictInfos;
            districtNameDropDownList.DataValueField = "Id";
            districtNameDropDownList.DataTextField = "DistrictName";
            districtNameDropDownList.DataBind();
            districtNameDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }
    }
}