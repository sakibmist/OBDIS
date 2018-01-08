using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.DAL
{
    public class CampaignInfoGateway:DBConnection
    {
        public  int Save(CampaignInfo aCampaignInfo)
        {
            int rowAffected = 0;

            string query = "INSERT INTO CampaignInfo VALUES('" + aCampaignInfo.Image + "','" + aCampaignInfo.Title + "','" + aCampaignInfo.Location + "','" + aCampaignInfo.Achievement + "','" + aCampaignInfo.PublishDate + "') ";

            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected; 
        }

        public  List<CampaignInfo> GetAllCampaignInfo()
        {

            List<CampaignInfo> aCampaignInfos  = null;
            string query = "SELECT * FROM CampaignInfo ORDER BY Id DESC";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                aCampaignInfos = new List<CampaignInfo>();
                while (Reader.Read())
                {
                    CampaignInfo aCampaignInfo = new CampaignInfo
                    {
                        Id = (int)Reader["Id"],
                        Image = Reader["Image"].ToString(),
                        Title = Reader["Title"].ToString(),
                        Location = Reader["Location"].ToString(),
                        Achievement = Reader["Achievement"].ToString(),
                        PublishDate = Convert.ToDateTime(Reader["PublishDate"]) 
                        
                    };
                    aCampaignInfos.Add(aCampaignInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return aCampaignInfos;
        }
    }
}