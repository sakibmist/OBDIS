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
    
    public partial class SubDistrictGridView : System.Web.UI.Page
    {
        private SubDistrictInfoManager _subDistrictInfoManager = new SubDistrictInfoManager();
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
                        DeleteBySubDistrictId(id);
                    }
                    else
                    {
                        // GetDataByBookId(id); ai kaj kajta important.
                    }

                }

              

            }
            LoadSubDistrictGridView();
        }
        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }

        private void DeleteBySubDistrictId(int id)
        {
            string msg = _subDistrictInfoManager.DeleteSubDistrict(id);
            if (msg == "deleted")
            {
                DisplayMessage("Deleted Successfully", Color.OrangeRed);

            }
            else if (msg == "failed")
            {
                DisplayMessage("Deleted Failed! Try Again.", Color.Red);
            }
        }
        private void LoadSubDistrictGridView()
        {
            List<SubDisDistrictDivisionInfo> subDisDistrictDivisionInfos = _subDistrictInfoManager.GetAllAreaInfo() ?? new List<SubDisDistrictDivisionInfo>();
            SubDistrictInfoGridView.DataSource = subDisDistrictDivisionInfos;
            SubDistrictInfoGridView.DataBind();
        }
    }
}