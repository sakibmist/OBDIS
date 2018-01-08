using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OBDSystemAPP.Models;

namespace OBDSystemAPP.DAL
{
    public class BloodInfoGateway:DBConnection
    {

        public int SaveBloodGroup(BloodInfo aBloodInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO BloodInfo VALUES('" + aBloodInfo.BloodGroupName + "',GETDATE() )";
            Connection.Open(); ;
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<BloodInfo> GetAllBloodGroup()
        {
            List<BloodInfo> aBloodInfos = null;
            string query = "SELECT * FROM BloodInfo ORDER BY Id DESC";
            Connection.Open();
            Command =new SqlCommand(query ,Connection );
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                aBloodInfos=new List<BloodInfo>();
                while (Reader.Read())
                {
                    BloodInfo aBloodInfo=new BloodInfo();
                    aBloodInfo.Id = (int)Reader["Id"];
                    aBloodInfo.BloodGroupName = Reader["BloodGroupName"].ToString();
                    aBloodInfos.Add(aBloodInfo);
                }
                Reader.Close();
            }
            Connection.Close();
            return aBloodInfos;
        }

        public  bool IsDuplicatBldGroup(BloodInfo aBloodInfo)
        {
            string query = "SELECT * FROM BloodInfo WHERE Id='"+aBloodInfo .Id+"'";
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

        public  int DeleteBloodGroup(int id)
        {
            int rowAffected = 0;
            string query = "DELETE FROM BloodInfo WHERE Id='"+id+"' ";
            Connection.Open(); ;
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}