using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.UI
{
    public partial class MsgToBldDonor : System.Web.UI.Page
    {
        private ReportInfoManager _reportInfoManager = new ReportInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void sendMsgButton_Click(object sender, EventArgs e)
        {
            string a = NameTextBox.Text;
            string b = DonorIdTextBox .Text;
            string c = msgTextBox.Text;

            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c))
            {
                ReportInfo aReportInfo = new ReportInfo();
                aReportInfo.Name = a;
                aReportInfo.DonorId = b;
                aReportInfo.Msg  = c;
                string msg = _reportInfoManager.SaveReportInfo(aReportInfo);
                if (msg == "success")
                {
                    DisplayMessage("Saved Successfully", Color.ForestGreen); 
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Saved Failed! Try Again.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.Red);
            }
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = null;
            DonorIdTextBox.Text = null;
            msgTextBox.Text = null;
            InfoMessageLabel.Text = null;
        }
    }
}