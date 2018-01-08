using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;

namespace OBDSystemAPP.UI
{
    public partial class FindDonorOrganization : System.Web.UI.Page
    {
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDistrictDropdown();
        }
        private void LoadDistrictDropdown()
        {
            List<Models.DistrictInfo> aDistrictInfos = _districtInfoManager.GetAllDistrictName() ?? new List<Models.DistrictInfo>();
            OrgDistrictDropdownList.DataSource = aDistrictInfos;
            OrgDistrictDropdownList.DataValueField = "Id";
            OrgDistrictDropdownList.DataTextField = "DistrictName";
            OrgDistrictDropdownList.DataBind();
            OrgDistrictDropdownList.Items.Insert(0, new ListItem("Select One", ""));
        } 
        protected void SearchOrganizationButton_Click(object sender, EventArgs e)
        {

        }

        protected void resetButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}