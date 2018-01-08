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
    public partial class FindDonor : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        private BloodInfoManager _bloodInfoManager = new BloodInfoManager();
        private SubDistrictInfoManager _subDistrictInfoManager = new SubDistrictInfoManager();
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBloodInfoDropdown();
                LoadOrgDivisionDropDownList(); 
            }
            
        }
        
        private void LoadBloodInfoDropdown()
        {
            List<BloodInfo> aBloodInfos = _bloodInfoManager.GetAllBloodGroup() ?? new List<BloodInfo>();
            BloodGroupDropDownList.DataSource = aBloodInfos;
            BloodGroupDropDownList.DataValueField = "Id";
            BloodGroupDropDownList.DataTextField = "BloodGroupName";
            BloodGroupDropDownList.DataBind();
            BloodGroupDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }
        

        private void LoadOrgDivisionDropDownList()
        {
            List<DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<DivisionInfo>();
            DivisionDropDownList.DataSource = aDivisionInfos;
            DivisionDropDownList.DataValueField = "Id";
            DivisionDropDownList.DataTextField = "DivisionName";
            DivisionDropDownList.DataBind();
            DivisionDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }
        private  void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void searchDonorButton_Click(object sender, EventArgs e)
        {
            LoadGridViewByPartialSearch();
         
        }
        private void LoadGridViewByPartialSearch()
        {
            string v1 = DivisionDropDownList.SelectedValue;
            string v2 = DistrictDropDownList.SelectedValue;
            string v3 = BloodGroupDropDownList.SelectedValue;
            string v4 = SubDistrictDropDownList.SelectedValue;
            if (string.IsNullOrEmpty(v1) && string.IsNullOrEmpty(v2) && string.IsNullOrEmpty(v3) && string.IsNullOrEmpty(v4))
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.Red);
                FindDonorInfoGridView.Visible = false;
            }
            else
            {

                int a = Convert.ToInt32(v1);
                int b = Convert.ToInt32(v2);
                int c = Convert.ToInt32(v3);
                int d = Convert.ToInt32(v4);
                string es = "Enable";
                string publishStatus = "publish";
                List<DonorDetailInfoForSearch> aOrganizationDistDivisionInfos = _donorInfoManager.GetDonorDetail(a,b,c,d,es,publishStatus) ?? new List<DonorDetailInfoForSearch>();
                FindDonorInfoGridView.DataSource = aOrganizationDistDivisionInfos;
                FindDonorInfoGridView.DataBind();
                FindDonorInfoGridView.Visible = true;
            }

        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            DivisionDropDownList.Text = null;
            DistrictDropDownList.Text = null;
            BloodGroupDropDownList.Text = null;
            SubDistrictDropDownList.Text = null;
            InfoMessageLabel.Text = null;
            FindDonorInfoGridView.Visible  = false;
        }

        protected void DivisionDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var divisionId = DivisionDropDownList.SelectedValue;
            /*if (string.IsNullOrWhiteSpace(divisionId)) return;*/
            int aDivisionId = Convert.ToInt32(divisionId);
            List<DistrictInfo> aDivisionInfos = _districtInfoManager.GetAllDistrict(aDivisionId) ?? new List<DistrictInfo>();
            DistrictDropDownList.DataSource = aDivisionInfos;
            DistrictDropDownList.DataValueField = "Id";
            DistrictDropDownList.DataTextField = "DistrictName";
            DistrictDropDownList.DataBind();
            DistrictDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }

        protected void DistrictDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var districtId = DistrictDropDownList.SelectedValue;
            /*if (string.IsNullOrWhiteSpace(divisionId)) return;*/
            int aDistrictId = Convert.ToInt32(districtId);
            List<SubDistrictInfo> aDistrictInfos = _subDistrictInfoManager.GetAllDistrict(aDistrictId) ?? new List<SubDistrictInfo>();
            SubDistrictDropDownList.DataSource = aDistrictInfos;
            SubDistrictDropDownList.DataValueField = "Id";
            SubDistrictDropDownList.DataTextField = "SubDistrictName";
            SubDistrictDropDownList.DataBind();
            SubDistrictDropDownList.Items.Insert(0, new ListItem("Select One", ""));

        } 
        
    }
}