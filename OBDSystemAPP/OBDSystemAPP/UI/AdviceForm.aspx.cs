using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;

namespace OBDSystemAPP.UI
{
    public partial class AdviceForm : System.Web.UI.Page
    {
        protected int totalNumberOfDonor;

        protected int totalNumberOfOrganization;
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        private BldOrganizationManager _bldOrganizationManager = new BldOrganizationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTotalNumberOfDonor();
            GetTotalNumberOfOrganization();
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