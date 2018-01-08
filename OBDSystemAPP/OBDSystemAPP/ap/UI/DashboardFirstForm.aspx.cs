using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.ap.UI
{
    public partial class DashboardFirstForm : System.Web.UI.Page
    {
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        private AdminInfoManager _adminInfoManager = new AdminInfoManager();
        private BldOrganizationManager _bldOrganizationManager = new BldOrganizationManager();
        protected int totalNumberOfDonor;
        protected int totalNumberOfOrganization;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx"); 
                    
                }
                GetTotalNumberOfDonor();
                GetTotalNumberOfOrganization();
            }

          
        }

        private void GetTotalNumberOfOrganization()
        {
            totalNumberOfOrganization = _bldOrganizationManager.GetTotalNumberOfOrganization();
        }

        private void GetTotalNumberOfDonor()
        {
             totalNumberOfDonor = _donorInfoManager.GetNumberOfDonor();
        }

        

       
    }
}