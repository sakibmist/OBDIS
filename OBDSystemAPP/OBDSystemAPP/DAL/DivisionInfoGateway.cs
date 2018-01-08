using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.DAL
{
    public class DivisionInfoGateway:DBConnection
    {
        public int SaveDivisionName(DivisionInfo aDivisionInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO DivisionInfo VALUES('" + aDivisionInfo.DivisionName + "',GETDATE() )";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection .Close();
            return rowAffected;
        }

        public List<DivisionInfo> GetAllDivision()
        { 
            
            List<DivisionInfo> aDivisionInfos = null;
            string query = "SELECT * FROM DivisionInfo ORDER BY Id DESC";
            Connection.Open();
            Command =new SqlCommand(query,Connection );
            Reader = Command.ExecuteReader();
            if (Reader .HasRows)
            {
                aDivisionInfos = new List<DivisionInfo>();
                while (Reader.Read())
                {
                    DivisionInfo aInfo=new DivisionInfo();
                    aInfo.Id =(int) Reader["Id"];
                    aInfo.DivisionName = Reader["DivisionName"].ToString();
                    aDivisionInfos.Add(aInfo);
                }
                Reader.Close();
            }
            Connection.Close();
            return aDivisionInfos;
        }

        public  int DeleteDivisionById(int id)
        {
           /* try
            {
                int rowAffected = 0;
                string query = "DELETE FROM DivisionInfo WHERE Id='" + id + "'";
                Connection.Open();
                Command = new SqlCommand(query, Connection);
                rowAffected = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffected;
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {

                return 0;
            }*/
            int rowAffected = 0;
            string query = "DELETE FROM DivisionInfo WHERE Id='" + id + "'";
            Connection .Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection .Close();
            return rowAffected;
        }

        public  bool IsDivisionNameExist(DivisionInfo aDivisionInfo)
        {
            string query = "SELECT * FROM DivisionInfo WHERE DivisionName='" + aDivisionInfo.DivisionName + "'";
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

        public  DivisionInfo GetDivisionDataById(int id)
        {

            DivisionInfo aDivisionInfo = null;
            string query = "SELECT * FROM DivisionInfo WHERE Id='"+id+"'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                aDivisionInfo = new DivisionInfo
                {

                    DivisionName = Reader["DivisionName"].ToString(),
                    
                };
                Reader.Close();
            }

            Connection.Close();
            return aDivisionInfo;
            
        }

        public  int UpdateDivisionInfo(DivisionInfo aDivisionInfo)
        {
            int rowAffected = 0;
            string query = "UPDATE DivisionInfo SET DivisionName='" + aDivisionInfo.DivisionName  + "'  WHERE Id='" + aDivisionInfo.Id + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected; 
        }
    }
}