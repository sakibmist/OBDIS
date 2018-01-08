using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.ap.UI
{
    public partial class showBloodInfo : System.Web.UI.Page
    {
        private BloodInfoManager _bloodInfoManager = new BloodInfoManager();
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
                        DeleteByBloodGroupId(id);
                    }
                    else
                    {
                        // GetDataByBookId(id); ai kaj kajta important.
                    }

                }
            }

            LoadGridView();
           
        }

        private void LoadGridView()
        {
            List<BloodInfo> aBloodInfos = _bloodInfoManager.GetAllBloodGroup() ?? new List<BloodInfo>();
            BloodInfoGridView.DataSource = aBloodInfos;
            BloodInfoGridView.DataBind();
        }
        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }

        private void DeleteByBloodGroupId(int id)
        {
            string msg = _bloodInfoManager.DeleteBloodGroup(id);
            if (msg == "deleted")
            {
                DisplayMessage("Deleted Successfully.", Color.OrangeRed);
             
                 
            }
            else if (msg == "failed")
            {
                DisplayMessage("Deleted Failed!", Color.Red);
            }
        }
    }
}