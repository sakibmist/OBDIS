using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.DAL
{
    public class DistrictInfoGateway:DBConnection
    {
        public  int SaveDistrictName(DistrictInfo aDistrictInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO DistrictInfo VALUES('" + aDistrictInfo.DistrictName + "','"+aDistrictInfo.DivisionInfoId+"',GETDATE() )";
            Connection.Open();
            Command =new SqlCommand(query ,Connection );
            rowAffected = Command.ExecuteNonQuery();
            Connection .Close();
            return rowAffected;
        }

        public List<DistrictInfo> GetAllDistrictName(int aDivisionId)
        {
            List<DistrictInfo> aDistrictInfos = null;
            string query = "SELECT * FROM DistrictInfo WHERE DivisionInfoId='" + aDivisionId + "'";
            Connection .Open();
            Command =new SqlCommand(query ,Connection );
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                aDistrictInfos = new List<DistrictInfo>();
                while (Reader.Read())
                {
                    DistrictInfo aDistrictInfo=new DistrictInfo();
                    aDistrictInfo.Id = (int)Reader["Id"];
                    aDistrictInfo.DistrictName = Reader["DistrictName"].ToString();
                    aDistrictInfos.Add(aDistrictInfo);
                   
                }
                Reader.Close();
            }
            Connection .Close();
            return aDistrictInfos;
        }
 

        public  List<ViewModels.DistrictDivisionAreaInfo> GetAllDistrictDivisionInfo()
        {
            List<DistrictDivisionAreaInfo> subDisDistrictDivisionInfos = null;
            string query = "SELECT d.Id,d.DistrictName,di.DivisionName FROM  DistrictInfo d JOIN DivisionInfo di ON di.Id=d.DivisionInfoId";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                subDisDistrictDivisionInfos = new List<DistrictDivisionAreaInfo>();
                while (Reader.Read())
                {
                    DistrictDivisionAreaInfo aSubDisDistrictDivisionInfo = new DistrictDivisionAreaInfo
                    { 
                        DistrictId=(int)Reader ["Id"],
                        DistrictName = Reader["DistrictName"].ToString(),
                        DivisionName = Reader["DivisionName"].ToString()
                    };
                    subDisDistrictDivisionInfos.Add(aSubDisDistrictDivisionInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return subDisDistrictDivisionInfos;
        }

       
        public  bool IsDistrictNameExist(DistrictInfo aDistrictInfo)
        {
            string query = "SELECT * FROM DistrictInfo WHERE DistrictName='" + aDistrictInfo.DistrictName + "' ";
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

        public  int DeleteDistrict(int id)
        {
            int rowAffected = 0;
            string query = "DELETE  FROM DistrictInfo WHERE Id='" + id + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public  List<DistrictInfo> GetAllDistrictName()
        {
            List<DistrictInfo> aDistrictInfos = null;
            string query = "SELECT * FROM DistrictInfo ORDER BY Id DESC";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                aDistrictInfos = new List<DistrictInfo>();
                while (Reader.Read())
                {
                    DistrictInfo aDistrictInfo = new DistrictInfo();
                    aDistrictInfo.Id = (int)Reader["Id"];
                    aDistrictInfo.DistrictName = Reader["DistrictName"].ToString();
                    aDistrictInfos.Add(aDistrictInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return aDistrictInfos;
        }
    }
}