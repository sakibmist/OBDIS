using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.UI
{
    public partial class ProfileGridview : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        private BloodInfoManager _bloodInfoManager = new BloodInfoManager();
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        private SubDistrictInfoManager _subDistrictInfoManager = new SubDistrictInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(!IsPostBack)
            {
                if (Session["DonorUserId"] == null) //for each page security.
                {
                    Response.Redirect("Login.aspx");
                }
                LoadBloodInfoDropdown(); 
                LoadDivisionDropdown();
                if (Request.QueryString["DonorId"] != null)
                {
                    int donorId = Convert.ToInt32(Request.QueryString["DonorId"]); 
                    GetDataByDonorId(donorId); 
                }  
            } 
        }

        private void GetDataByDonorId(int donorId)
        { 
            DonorInfo aDonorInfo = _donorInfoManager.GetDonorUpdateDataById(donorId);
            donorNameTextBox.Text = aDonorInfo.DonorName;
            donorTypeDropDownList.SelectedValue = aDonorInfo.DonorType;
            fatherNameTextBox.Text = aDonorInfo.FatherName;
            motherNameTextBox.Text = aDonorInfo.MotherName;
            bloodGroupDropDownList.SelectedValue= aDonorInfo.BloodInfoId.ToString( );
            genderDropDownList.SelectedValue = aDonorInfo.Gender;
            dobTextBox.Text = aDonorInfo.Dob.ToString();
            mobileNoTextBox.Text = aDonorInfo.Mobile;
            alterPhoneTextBox.Text = aDonorInfo.AlterMobile;
            emailTextBox.Text = aDonorInfo.Email;
            divisionDropDownList.SelectedValue =aDonorInfo.DivisionInfoId.ToString();
            districtDropDownList.SelectedValue = aDonorInfo.DistrictInfoId.ToString();
            subDistrictDropDownList.SelectedValue = aDonorInfo.SubDistrictInfoId.ToString();
            cityTextBox.Text = aDonorInfo.City;
            donorIdTextBox.Text = aDonorInfo.DonorUserId;
            passwordTextBox.Text = aDonorInfo.DonorPassword;
            abilityDropDownList.SelectedValue  = aDonorInfo.AbilityToDonate;
        }
        private void LoadBloodInfoDropdown()
        {
            List<BloodInfo> aBloodInfos = _bloodInfoManager.GetAllBloodGroup() ?? new List<BloodInfo>();
            bloodGroupDropDownList.DataSource = aBloodInfos;
            bloodGroupDropDownList.DataValueField = "Id";
            bloodGroupDropDownList.DataTextField = "BloodGroupName";
            bloodGroupDropDownList.DataBind(); 
        }

        private void LoadDivisionDropdown()
        {
            List<DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<DivisionInfo>();
            divisionDropDownList.DataSource = aDivisionInfos;
            divisionDropDownList.DataValueField = "Id";
            divisionDropDownList.DataTextField = "DivisionName";
            divisionDropDownList.DataBind(); 
        }
        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        } 

        protected void updateButton_Click(object sender, EventArgs e)
        {

            string a = donorIdTextBox.Text;
            string b = donorTypeDropDownList.Text;
            string c = fatherNameTextBox.Text;
            string d = motherNameTextBox.Text;
            string es = bloodGroupDropDownList.Text;
            string f = genderDropDownList.Text;
            string g = dobTextBox.Text;
            string h = mobileNoTextBox.Text; 
           string hs = abilityDropDownList.Text;
            string i = divisionDropDownList.Text;
            string j = districtDropDownList.Text;
            string k = subDistrictDropDownList.Text;
            string l = cityTextBox.Text;
            string m = donorIdTextBox.Text;
            string n = passwordTextBox.Text;
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c) && !string.IsNullOrEmpty(d) && !string.IsNullOrEmpty(es) && !string.IsNullOrEmpty(f) && !string.IsNullOrEmpty(g) && !string.IsNullOrEmpty(h) && !string.IsNullOrEmpty(i) && !string.IsNullOrEmpty(j) && !string.IsNullOrEmpty(k) && !string.IsNullOrEmpty(l) && !string.IsNullOrEmpty(m) && !string.IsNullOrEmpty(n) && Request.QueryString["DonorId"] != null)
            { 
              DonorInfo aDonorInfo = new DonorInfo(); 
                int ab = Convert .ToInt32( Request.QueryString["DonorId"]);
                aDonorInfo.Id = ab;
                aDonorInfo.DonorName = a;
                aDonorInfo.DonorType = b;
                aDonorInfo.FatherName = c;
                aDonorInfo.MotherName = d;
                aDonorInfo.BloodInfoId = Convert .ToInt32(es);
                aDonorInfo.Gender = f;
                aDonorInfo.Dob = Convert.ToDateTime(g);
                aDonorInfo.Mobile = h;
                aDonorInfo.AlterMobile = alterPhoneTextBox.Text;
                aDonorInfo.Email = emailTextBox.Text;
                aDonorInfo.DivisionInfoId = Convert.ToInt32(i);
                aDonorInfo.DistrictInfoId = Convert.ToInt32(j);
                aDonorInfo.SubDistrictInfoId = Convert.ToInt32(k);
                aDonorInfo.City = l;
                aDonorInfo.DonorUserId = m;
                aDonorInfo.DonorPassword = n;
                aDonorInfo.AbilityToDonate = hs;
                string msg = _donorInfoManager.UpdateDonorInfo(aDonorInfo);
                if (msg=="update")
                {
                    DisplayMessage("Updated Successfully", Color.ForestGreen);
                    Response.Redirect("DonorProfile.aspx");
                }else if (msg=="failed")
                {
                    DisplayMessage("Update data failed.", Color.ForestGreen);
                }
                else if (msg == "exist")
                {
                    DisplayMessage("Duplicate Data Required! Check Mobile No.& UserId.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again",Color.Red );
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            if (Session["DonorUserId"] != null)
            { 
                Session.Remove("DonorUserId");
                Response.Redirect("Login.aspx"); 
            }
        }

        protected void divisionDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var divisionId = divisionDropDownList.SelectedValue;
            /*if (string.IsNullOrWhiteSpace(divisionId)) return;*/
            int aDivisionId = Convert.ToInt32(divisionId);
            List<DistrictInfo> aDistrictInfos = _districtInfoManager.GetAllDistrict(aDivisionId) ?? new List<DistrictInfo>();
            districtDropDownList.DataSource = aDistrictInfos;
            districtDropDownList.DataValueField = "Id";
            districtDropDownList.DataTextField = "DistrictName";
            districtDropDownList.DataBind();
            districtDropDownList.Items.Insert(0, new ListItem("Select One", "")); 
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var districtId = districtDropDownList.SelectedValue;
            /*if (string.IsNullOrWhiteSpace(divisionId)) return;*/
            int aDistrictId = Convert.ToInt32(districtId);
            List<SubDistrictInfo> aDistrictInfos = _subDistrictInfoManager.GetAllDistrict(aDistrictId) ?? new List<SubDistrictInfo>();
            subDistrictDropDownList.DataSource = aDistrictInfos;
            subDistrictDropDownList.DataValueField = "Id";
            subDistrictDropDownList.DataTextField = "SubDistrictName";
            subDistrictDropDownList.DataBind();
            subDistrictDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }

        
    }
}