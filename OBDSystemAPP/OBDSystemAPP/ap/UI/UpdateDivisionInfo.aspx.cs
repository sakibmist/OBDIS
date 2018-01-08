using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.ap.UI
{
    public partial class UpdateDivisionInfo : System.Web.UI.Page
    {
        DivisionInfoManager _divisionInfoManager = new DivisionInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!IsPostBack)
            {
                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx");
                }
                if (Request.QueryString["Id"] != null && Request.QueryString["Update"]!=null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    GetDataById(id);
                }

            }
        }

        private void GetDataById(int id)
        {
            Models.DivisionInfo aDivisionInfo = _divisionInfoManager.GetDataById(id) ?? new Models.DivisionInfo();
            divisionNameTextBox.Text = aDivisionInfo.DivisionName;
        }

        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        } 
        protected void UpdateDivisionButton_Click(object sender, EventArgs e)
        {

            string divisionName = divisionNameTextBox.Text;

            if (!string.IsNullOrEmpty(divisionName) && Request.QueryString["Id"] != null)
            {

                Models.DivisionInfo aDivisionInfo = new Models.DivisionInfo();
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                aDivisionInfo.Id = id;
                aDivisionInfo.DivisionName = divisionName;


                string msg = _divisionInfoManager.UpdateDivisionInfo(aDivisionInfo);
                if (msg == "update")
                {
                    DisplayMessage("Updated Successfully", Color.ForestGreen);
                     
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Update data failed.", Color.ForestGreen);
                }
                else if (msg == "exist")
                {
                    DisplayMessage("Duplicate Data Required! Same Division Name Exist.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again", Color.Red);
            }
        }
    }
}