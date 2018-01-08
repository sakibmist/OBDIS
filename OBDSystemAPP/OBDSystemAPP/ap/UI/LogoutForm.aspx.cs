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
    public partial class LogoutForm : System.Web.UI.Page
    {
        private AdminInfoManager _adminInfoManager = new AdminInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminId"] == null)
            {
                Response.Redirect("IndexLogin.aspx");
            }
            LoadAdminInfoGridView();
        }

        private void LoadAdminInfoGridView()
        {
            string adId = Session["adminId"].ToString();
            List<AdminInfo> adminInfos = _adminInfoManager.GetAllAdminInfo(adId) ?? new List<AdminInfo>();
            AdminDataList.DataSource = adminInfos;
            AdminDataList .DataBind();
        }

        protected void LogOutButton_Click(object sender, EventArgs e)
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