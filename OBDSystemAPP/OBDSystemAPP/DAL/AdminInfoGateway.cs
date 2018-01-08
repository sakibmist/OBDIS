using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.DAL
{
    public class AdminInfoGateway:DBConnection
    { 
        public int Save(AdminInfo aadminInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO AdminInfo VALUES('" + aadminInfo.AdminName + "','" + aadminInfo.Designation + "','" + aadminInfo.Photo+ "','" + aadminInfo.Email + "','" + aadminInfo.AdminId + "','" + aadminInfo.Passwords + "',GETDATE() )";

            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;  
        }

       

        public  bool IsMatch(string a, string b)
        {
            string query = "SELECT * FROM AdminInfo WHERE AdminId='" + a + "' AND Passwords='"+b+"'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                return true;
            }
            Reader.Close();

            Connection.Close();
            return false;    
        }

        internal bool IsDuplicat(AdminInfo aadminInfo)
        {
            string query = "SELECT * FROM AdminInfo WHERE Email='" + aadminInfo.Email + "' AND AdminId='" + aadminInfo.AdminId + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                return true;
            }
            Reader.Close();

            Connection.Close();
            return false; 
        }

        

        public  AdminInfo GetAllInfo(string adminId)
        {
            AdminInfo aDInfo = null;
            string query = "SELECT * FROM AdminInfo WHERE AdminId='" + adminId + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                aDInfo = new AdminInfo
                {

                    AdminName = Reader["AdminName"].ToString(),
                    Photo = Reader["Photo"].ToString(),
                    Designation = Reader["Designation"].ToString(),
                    Email = Reader["Email"].ToString(),
                    AdminId = Reader["AdminId"].ToString(),
                    Passwords = Reader["Passwords"].ToString(),
                    CreatedAt = Convert.ToDateTime(Reader["CreatedAt"])
                };
                Reader.Close();
            }

            Connection.Close();
            return aDInfo;  
        }

        public  List<AdminInfo> GetAllAdminInfo(string adId)
        {
            List<AdminInfo> bldOrganizationInfos = null;
            string query = "SELECT * FROM AdminInfo WHERE AdminId='" + adId + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<AdminInfo>();
                while (Reader.Read())
                {
                    AdminInfo bldOrganizationInfo = new AdminInfo
                    {
                        AdminName = Reader["AdminName"].ToString(),
                        Photo = Reader["Photo"].ToString(),
                        Designation = Reader["Designation"].ToString(),
                        Email = Reader["Email"].ToString(),
                        AdminId = Reader["AdminId"].ToString(),
                        Passwords = Reader["Passwords"].ToString(),
                        CreatedAt = Convert.ToDateTime(Reader["CreatedAt"])
                    };
                    bldOrganizationInfos.Add(bldOrganizationInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return bldOrganizationInfos;
        }
    }
}