using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.ap.UI
{
    public partial class BldOrganizationDetailInfo : System.Web.UI.Page
    {
        private BldOrganizationManager _bldOrganizationManager = new BldOrganizationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx");
                } 
            }
            LoadBldOrganizationInfoGridView();
        }

        private void LoadBldOrganizationInfoGridView()
        {
            List<OrganizationDistDivisionInfo> aOrganizationDistDivisionInfos = _bldOrganizationManager.GetOrganizationDetail() ?? new List<OrganizationDistDivisionInfo>();
            BldOrganizationInfoGridView.DataSource = aOrganizationDistDivisionInfos;
            BldOrganizationInfoGridView.DataBind();
        }
    }
}