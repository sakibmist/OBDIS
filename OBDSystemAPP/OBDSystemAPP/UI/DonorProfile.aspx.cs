using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.UI
{
    public partial class DonorProfile : System.Web.UI.Page
    {
        private DonorInfoManager _donorInfoManager = new DonorInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["DonorUserId"] == null) //for each page security.
                {
                    Response.Redirect("Login.aspx");
                }
                
                
            }

            LoadDonorDatalist();
        }

        private void LoadDonorDatalist()
        {
            string donorUserId = Session["DonorUserId"].ToString();


            List<DonorProfileInfo> aDonorInfos = _donorInfoManager.GetAllDonorInfo(donorUserId) ?? new List<DonorProfileInfo>();
            DonorDataList.DataSource = aDonorInfos;
            DonorDataList.DataBind();
        }

        

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            if (Session["DonorUserId"] != null)
            {
                Session.Remove("DonorUserId");
                Response.Redirect("Login.aspx");
                //Session.Clear();
                //Session.RemoveAll();
            }
        }
    }
}