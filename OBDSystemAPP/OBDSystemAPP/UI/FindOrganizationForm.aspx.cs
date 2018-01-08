using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.UI
{
    public partial class FindOrganizationForm : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDivisionDropdown();
            }
        }

        private void LoadDivisionDropdown()
        {
            List<DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<DivisionInfo>();
            
        }
       /* private void LoadDivisionDropdown()
        {

            List<DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<DivisionInfo>();
            orgDivisionDropdownList.DataSource = aDivisionInfos;
            orgDivisionDropdownList.DataValueField = "Id";
            orgDivisionDropdownList.DataTextField = "DivisionName";
            orgDivisionDropdownList.DataBind();
            orgDivisionDropdownList.Items.Insert(0, new ListItem("Select One", ""));

        }*/
    }
}