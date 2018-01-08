using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.ap.UI
{
    public partial class DashBoardForm : System.Web.UI.MasterPage
    {
        protected string Name;
        protected string Photo;
        protected int NumberOfPendingDonor;
        protected int NumberOfMsg;
        private AdminInfoManager _adminInfoManager = new AdminInfoManager();
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        private ReportInfoManager _reportInfoManager = new ReportInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 if (Session["adminId"] == null)
                 {
                     Response.Redirect("IndexLogin.aspx");
                 }
                 
                 if (Session["adminId"] == null) return;
                 var adminId = Session["adminId"].ToString();

                 SetAdminInfo(adminId);

            }
            GetNumberOfPendingDonor();
            GetNumberOfMsg();
        }

        private void GetNumberOfMsg()
        {
            NumberOfMsg = _reportInfoManager.GetNumberOfMsg();
        }

        private void GetNumberOfPendingDonor()
        {
            string  status = "unpublish";
            NumberOfPendingDonor = _donorInfoManager.GetNumberOfPendingDonor(status);

        }

        private void SetAdminInfo(string adminId)
        {
            AdminInfo adminInfos = _adminInfoManager.GetAllInfo(adminId) ?? new AdminInfo();

            Name = adminInfos.AdminName;
            Photo = Convert .ToString( adminInfos.Photo);
        }

       

        protected void logOutButton_Click(object sender, EventArgs e)
        {
            if (Session["adminId"] != null)
            {
                Session.Remove("adminId");
                Response.Redirect("IndexLogin.aspx");
                //Session.Clear();
                //Session.RemoveAll();
            }
        }

        
    }
}