using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OBDSystemAPP.BLL;
using OBDSystemAPP.Models;
using System.IO;

namespace OBDSystemAPP.ap.UI
{
    public partial class AdminRegistration : System.Web.UI.Page
    {
        private AdminInfoManager _adminInfoManager = new AdminInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               /* string[] filePaths = Directory.GetFiles(Server.MapPath("ImageBox/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths )
                {
                    string fileName = Path.GetFileName(filePath);
                    files.Add(new ListItem(fileName, "ImageBox/" + fileName));
                }*/
            }
        }
        public void DisplayMessage(string text, Color color)
        {
            InfoMessageLabel.Text = text;
            InfoMessageLabel.ForeColor = color;
            InfoMessageLabel.Visible = true;
        }
        protected void saveAdminInfoButton_Click(object sender, EventArgs e)
        {
            string a = adminNameTextBox.Text.Trim();
            string b = designationTextBox.Text;
            /*  string c = */
            string d = adminEmailTextBox.Text;
            string es = adminIdTextBox.Text;
            string f = AdminEnterPasswordTextBox.Text;

            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(d) && !string.IsNullOrEmpty(es) && !string.IsNullOrEmpty(f))
            {
                AdminInfo aadminInfo = new AdminInfo();
                aadminInfo.AdminName = a;
                aadminInfo.Designation = b;
                if (adminImageFileUpload.HasFiles)
                {
                    var fileName = Path.GetFileName(adminImageFileUpload.PostedFile.FileName);
                    const string basePath = @"/ap/UI/ImageBox/";
                    var serverPath = Server.MapPath("~" + basePath);
                    if (!Directory.Exists(serverPath)) Directory.CreateDirectory(serverPath);
                    
                    
                    var fileExtension = Path.GetExtension(fileName);
                    if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
                    {
                        adminImageFileUpload.PostedFile.SaveAs(serverPath  + fileName );
                        aadminInfo.Photo = basePath + fileName;
                    }
                    else
                    {
                        DisplayMessage("Does not match your password! Try Again.", Color.DarkRed);
                    }
                }

                aadminInfo.Email = d;
                aadminInfo.AdminId = es;
                aadminInfo.Passwords = f;
                string result = adminReEnterPasswordTextBox.Text;
                if (result == aadminInfo.Passwords)
                {
                    string msg = _adminInfoManager.Save(aadminInfo);
                    if (msg == "success")
                    {
                        DisplayMessage("Save Successfully.", Color.ForestGreen);
                        Response.Redirect("IndexLogin.aspx");
                    }
                    else if (msg == "failed")
                    {
                        DisplayMessage("Failed! Try Again.", Color.DarkRed);

                    }
                    else if (msg == "exist")
                    {
                        DisplayMessage("Duplicate Data Required! Check Email & Password.", Color.Red);
                    }
                }
                else
                {
                    DisplayMessage("Only images(.jpg, .png, .gif) can be uploaded.Try Again.", Color.DarkRed);
                }
            }
            else
            {
                DisplayMessage("Empty Fields Are Required! Try Again.", Color.DarkRed);
            }

        }
    }
}