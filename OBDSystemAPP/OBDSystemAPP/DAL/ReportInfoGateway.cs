using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.DAL
{
    public class ReportInfoGateway : DBConnection
    {


        public int SaveReportInfo(Models.ReportInfo aReportInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO ReportInfo(Name,DonorId,Msg,CreatedAt)VALUES('" + aReportInfo.Name + "','" + aReportInfo.DonorId + "','" + aReportInfo.Msg + "', GETDATE() )";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public  List<Models.ReportInfo> GetAllReportInfo()
        {
            List<ReportInfo> aInfos = null;
            string query = "SELECT * FROM ReportInfo ORDER BY Id DESC";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                aInfos = new List<ReportInfo>();
                while (Reader.Read())
                {
                    ReportInfo bldOrganizationInfo = new ReportInfo
                    {
                        Id = Convert.ToInt32(Reader["Id"]),
                        Name = Reader["Name"].ToString(),
                        DonorId = Reader["DonorId"].ToString(),
                        Msg  = Reader["Msg"].ToString(),
                        CreatedAt = Convert .ToDateTime( Reader["CreatedAt"])
                    };
                    aInfos.Add(bldOrganizationInfo);
                }
                Reader.Close();
            }
            Connection.Close();
            return aInfos;
        }

        public  int GetNumberOfMsg()
        {
            int NumberOfMsg = 0;
            string query = " SELECT COUNT(*) FROM ReportInfo ";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            NumberOfMsg = (int)Command.ExecuteScalar();
            Connection.Close();
            return NumberOfMsg;
        }

        public  int DeleteDivisionById(int id)
        {
            int rowAffected = 0;
            string query = "DELETE FROM ReportInfo WHERE Id='" + id + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}