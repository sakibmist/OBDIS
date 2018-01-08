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
    public partial class DonorRegistrationForm : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        private BloodInfoManager _bloodInfoManager = new BloodInfoManager();
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        private SubDistrictInfoManager _subDistrictInfoManager = new SubDistrictInfoManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                LoadDivisionDropdown();
                LoadBloodInfoDropdown();
            }
        }


        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }

        private void LoadBloodInfoDropdown()
        {
            List<BloodInfo> aBloodInfos = _bloodInfoManager.GetAllBloodGroup() ?? new List<BloodInfo>();
            bloodGroupDropDownList.DataSource = aBloodInfos;
            bloodGroupDropDownList.DataValueField = "Id";
            bloodGroupDropDownList.DataTextField = "BloodGroupName";
            bloodGroupDropDownList.DataBind();
            bloodGroupDropDownList.Items.Insert(0, new ListItem("Select One", ""));
        }



        protected void submitButton_Click(object sender, EventArgs e)
        {
            string a = donorTypeDropDownList.SelectedValue;
            string b = donorNameTextBox.Text.Trim();
            string c = fatherNameTextBox.Text.Trim();
            string d = motherNameTextBox.Text.Trim();
            string es = bloodGroupDropDownList.SelectedValue;
            string f = genderDropDownList.SelectedValue;
            string g = dobTextBox.Text.Trim();
            string h = mobileNoTextBox.Text.Trim();
            string i = alterPhoneTextBox.Text.Trim();
            string j = emailTextBox.Text.Trim();
            string l = divisionDropDownList.SelectedValue;
            string m = districtDropDownList.SelectedValue;
            string n = subDistrictDropDownList.SelectedValue;
            string o = cityTextBox.Text.Trim();
            string p = donorIdTextBox.Text.Trim();
            string q = passwordTextBox.Text.Trim();
            string r = reenterPasswordTextBox.Text.Trim();
            string s = abilityDropDownList.SelectedValue;

            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c) &&
                !string.IsNullOrEmpty(d) && !string.IsNullOrEmpty(es) && !string.IsNullOrEmpty(f) &&
                !string.IsNullOrEmpty(g) && !string.IsNullOrEmpty(h) && !string.IsNullOrEmpty(l) &&
                !string.IsNullOrEmpty(m) && !string.IsNullOrEmpty(n) && !string.IsNullOrEmpty(o) &&
                !string.IsNullOrEmpty(p) && !string.IsNullOrEmpty(q) && !string.IsNullOrEmpty(r) &&
                !string.IsNullOrEmpty(s))
            {
                DonorInfo aDonorInfo = new DonorInfo();
                aDonorInfo.DonorType = a;
                aDonorInfo.DonorName = b;
                aDonorInfo.FatherName = c;
                aDonorInfo.MotherName = d;
                aDonorInfo.BloodInfoId = Convert.ToInt32(es);
                aDonorInfo.Gender = f;
                aDonorInfo.Dob = Convert.ToDateTime(g);
                aDonorInfo.Mobile = h;
                aDonorInfo.AlterMobile = i;
                aDonorInfo.Email = j;
                aDonorInfo.DivisionInfoId = Convert.ToInt32(l);
                aDonorInfo.DistrictInfoId = Convert.ToInt32(m);
                aDonorInfo.SubDistrictInfoId = Convert.ToInt32(n);
                aDonorInfo.City = o;
                aDonorInfo.DonorUserId = p;
                aDonorInfo.DonorPassword = q;
                aDonorInfo.AbilityToDonate = s;
                aDonorInfo.PublishStatus = "unpublish";
                if (r == aDonorInfo.DonorPassword)
                {
                    if (trueInfoCheckBox.Checked && PermissionInfoCheckBox.Checked)
                    {

                        string msg = _donorInfoManager.SaveDonorInfo(aDonorInfo);
                        if (msg == "success")
                        {
                            DisplayMessage("Saved Successfully", Color.ForestGreen);
                            Response.Redirect("Login.aspx");
                        }
                        else if (msg == "failed")
                        {
                            DisplayMessage("Saved Failed! Try Again.", Color.Red);
                        }
                        else if (msg == "exist")
                        {
                            DisplayMessage("Duplicate Data Required! Check Mobile No. & Password.", Color.Red);
                        }


                    }
                    else
                    {
                        DisplayMessage("Confirm Your Declaration! Try Again.", Color.Red);
                    }

                }
                else
                {

                    DisplayMessage("Password Not Match! Try Again.", Color.Red);

                }

            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.Red);
            }
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            donorTypeDropDownList.Text = null;
            donorNameTextBox.Text = null;
            fatherNameTextBox.Text = null;
            motherNameTextBox.Text = null;
            bloodGroupDropDownList.Text = null;
            genderDropDownList.Text = null;
            dobTextBox.Text = null;
            mobileNoTextBox.Text = null;
            alterPhoneTextBox.Text = null;
            emailTextBox.Text = null;
            divisionDropDownList.Text = null;
            districtDropDownList.Text = null;
            subDistrictDropDownList.Text = null; ;
            cityTextBox.Text = null;
            donorIdTextBox.Text = null;
            passwordTextBox.Text = null;
            reenterPasswordTextBox.Text = null;
            abilityDropDownList.Text = null;
            InfoMessageLabel.Text = null;
            trueInfoCheckBox.Checked = false;
            PermissionInfoCheckBox.Checked = false;
        }
        private void LoadDivisionDropdown()
        {
            List<DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<DivisionInfo>();
            divisionDropDownList.DataSource = aDivisionInfos;
            divisionDropDownList.DataValueField = "Id";
            divisionDropDownList.DataTextField = "DivisionName";
            divisionDropDownList.DataBind();
            divisionDropDownList.Items.Insert(0, new ListItem("Select One",""));
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
            districtDropDownList.Items.Insert(0, new ListItem("Select One",""));

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
            subDistrictDropDownList.Items.Insert(0, new ListItem("Select One",""));
        } 

    }

}