using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;

namespace OBDSystemAPP.ap.UI
{
    public partial class AllDivisions : System.Web.UI.Page
    {
        private DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
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
                        DeleteByDivisionId(id);
                    } 
                }

            }
            LoadGridView();
        }

        

        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        private void DeleteByDivisionId(int id)
        {
            string msg = _divisionInfoManager.DeleteDivisionById(id);
            if (msg == "deleted")
            {
                DisplayMessage("Deleted Successfully.", Color.OrangeRed);



            }
            else if (msg == "deleted")
            {
                DisplayMessage("Data Not Deleted.", Color.Red);
            }
        }

        private void LoadGridView()
        {
            List<Models.DivisionInfo> aDivisionInfos = _divisionInfoManager.GetAllDivision() ?? new List<Models.DivisionInfo>();
            DivisionInfoGridView.DataSource = aDivisionInfos;
            DivisionInfoGridView.DataBind();
        }
    }
}