using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;

namespace OBDSystemAPP.ap.UI
{
    public partial class CampaignInfo : System.Web.UI.Page
    {
        private CampaignInfoManager _campaignInfoManager = new CampaignInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["adminId"] == null)
                {
                    Response.Redirect("IndexLogin.aspx");
                }
            }
        }

        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void saveCampaignButton_Click(object sender, EventArgs e)
        {

            string b = titleTextBox.Text.Trim();

            string c = locationTextBox.Text.Trim();
            string es = achievementTextBox.Text.Trim();
            string d = publishDateTextBox.Text;
            if (!string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c) && !string.IsNullOrEmpty(d))
            {
                Models.CampaignInfo aCampaignInfo = new Models.CampaignInfo();
                
                if (campaignImageFileUpload.HasFiles)
                {
                    var fileName = Path.GetFileName(campaignImageFileUpload.PostedFile.FileName);
                    const string basePath = @"/ap/UI/ImageBox/CampaignPic/";
                    var serverPath = Server.MapPath("~" + basePath);
                    if (!Directory.Exists(serverPath)) Directory.CreateDirectory(serverPath);


                    var fileExtension = Path.GetExtension(fileName);
                    if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
                    {
                        campaignImageFileUpload.PostedFile.SaveAs(serverPath + fileName);
                        aCampaignInfo.Image = basePath + fileName;
                    }
                    else
                    {
                        DisplayMessage("Does not match your password! Try Again.", Color.DarkRed);
                    }
                }
                aCampaignInfo.Title = b;
                aCampaignInfo.Location = c;
                aCampaignInfo.PublishDate = Convert.ToDateTime(d);
                aCampaignInfo.Achievement = es;
                string msg = _campaignInfoManager.Save(aCampaignInfo);
                if (msg == "success")
                {
                    DisplayMessage("Save Successfully.", Color.ForestGreen);
                }
                else if (msg == "failed")
                {
                    DisplayMessage("Data Not Saved! Try Again.", Color.Red);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.DarkRed);
            }
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            InfoMessageLabel.Text = null;
            titleTextBox.Text = null;
            locationTextBox.Text = null;
            achievementTextBox.Text = null;
            publishDateTextBox.Text = null; 
        }
    }
}