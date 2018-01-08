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
    public partial class FindOrgInfo : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        private BldOrganizationManager _bldOrganizationManager = new BldOrganizationManager();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOrgDivisionDropDownList();
                
            }
        }

       

        private void LoadOrgDivisionDropDownList()
        {
            List<DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<DivisionInfo>();
            findDivisionDropDownList.DataSource = aDivisionInfos;
            findDivisionDropDownList.DataValueField = "Id";
            findDivisionDropDownList.DataTextField = "DivisionName";
            findDivisionDropDownList.DataBind();
            findDivisionDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }

        protected void searchOrgButton_Click(object sender, EventArgs e)
        {
            LoadGridViewByPartialSearch();
           
        }
        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        private void LoadGridViewByPartialSearch()
        {
            string searchValue1 = findDivisionDropDownList.SelectedValue;
            string searchValue2 = findDistrictDropDownList.SelectedValue;
            if (string.IsNullOrEmpty(searchValue1) && string.IsNullOrEmpty(searchValue2))
            {
                DisplayMessage("Empty Fields Are Required! Try Again.",Color.Red );
                FindOrganizationInfoGridView.Visible = false;
            }
            else
            {
                int a = Convert.ToInt32(searchValue1);
                int b = Convert.ToInt32(searchValue2);
                List<OrganizationDistDivisionInfo> aOrganizationDistDivisionInfos = _bldOrganizationManager.GetOrganizationDetail(a ,b ) ?? new List<OrganizationDistDivisionInfo>();
                FindOrganizationInfoGridView.DataSource = aOrganizationDistDivisionInfos;
                FindOrganizationInfoGridView.DataBind();
                FindOrganizationInfoGridView.Visible = true;
                InfoMessageLabel.Text = null;
            }
             
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            findDistrictDropDownList.Text = null;
            findDivisionDropDownList.Text = null;
            InfoMessageLabel.Text = null;
            FindOrganizationInfoGridView.Visible = false;
        }

        protected void findDivisionDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var divisionId = findDivisionDropDownList.SelectedValue;
            int aDivisionId = Convert.ToInt32(divisionId);
            List<DistrictInfo> aDivisionInfos = _districtInfoManager.GetAllDistrict(aDivisionId ) ?? new List<DistrictInfo>();
            findDistrictDropDownList.DataSource = aDivisionInfos;
            findDistrictDropDownList.DataValueField = "Id";
            findDistrictDropDownList.DataTextField = "DistrictName";
            findDistrictDropDownList.DataBind();
            findDistrictDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }


    }
}