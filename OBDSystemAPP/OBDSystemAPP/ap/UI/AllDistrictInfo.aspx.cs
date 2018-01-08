using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.ap.UI
{
    public partial class AllDistrictInfo : System.Web.UI.Page
    {
        private DistrictInfoManager _districtInfoManager = new DistrictInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx");
                }

                if (Request.QueryString["Id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    if (Request.QueryString["delete"] != null)
                    {
                        DeleteByDistrictId(id);
                    }
                    else
                    {
                        // GetDataByBookId(id); for editing..
                    }

                }
               
            }
            LoadDistrictGridView();
            
        }
        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }

        private void DeleteByDistrictId(int id)
        {
            string msg = _districtInfoManager.DeleteDistrict(id);
            if (msg == "deleted")
            {
                DisplayMessage("Deleted Successfully.", Color.OrangeRed);
            }
            else if (msg == "failed")
            {
                DisplayMessage("Delete Failed! Try Again.", Color.DarkRed);
            }
        }

        private void LoadDistrictGridView()
        {
            List<DistrictDivisionAreaInfo> aDistrictInfos = _districtInfoManager.GetAllDistrictDivisionInfo() ?? new List<DistrictDivisionAreaInfo>();
            DistrictInfoGridView.DataSource = aDistrictInfos;
            DistrictInfoGridView.DataBind();
        }
    }
}