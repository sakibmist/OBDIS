using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.DAL
{
    public class SubDistrictInfoGateway:DBConnection
    {
        

        public int SaveSubDistrictInfo(SubDistrictInfo aSubDistrictInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO SubDistrictInfo VALUES('"+aSubDistrictInfo.SubDistrictName+"','"+aSubDistrictInfo.DistrictInfoId+"',GETDATE() )";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection .Close();
            return rowAffected;
        }

        public List<SubDistrictInfo> GetAllSubDistrict(int aDistrictId)
        {
            List<SubDistrictInfo> subDistrictInfos = null;
            string query = "SELECT * FROM SubDistrictInfo WHERE DistrictInfoId='" + aDistrictId + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader .HasRows )
            {
                subDistrictInfos = new List<SubDistrictInfo>();
                while (Reader.Read())
                {
                    SubDistrictInfo aSubDistrictInfo = new SubDistrictInfo()
                    {
                        Id = (int)Reader ["Id"],
                        SubDistrictName = Reader ["SubDistrictName"].ToString() ,
                        DistrictInfoId =(int)Reader ["DistrictInfoId"]
                       
                    };
                    subDistrictInfos.Add(aSubDistrictInfo);
                }
                Reader.Close();
            }
            
            Connection.Close();
            return subDistrictInfos;
        }


        public  List<ViewModels.SubDisDistrictDivisionInfo> GetAllAreaInfo()
        {
            List<SubDisDistrictDivisionInfo> subDisDistrictDivisionInfos = null;
            string query = "SELECT s.Id,s.SubDistrictName,d.DistrictName, di.DivisionName FROM SubDistrictInfo s JOIN DistrictInfo d ON s.DistrictInfoId=d.Id JOIN DivisionInfo di ON di.Id=d.DivisionInfoId";
            Connection .Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                subDisDistrictDivisionInfos=new List<SubDisDistrictDivisionInfo>( );
                while (Reader.Read())
                {
                    SubDisDistrictDivisionInfo aSubDisDistrictDivisionInfo = new SubDisDistrictDivisionInfo
                    {
                        SubDistrictId = (int)Reader ["Id"],
                        SubDistrictName = Reader ["SubDistrictName"].ToString() ,
                        DistrictName = Reader ["DistrictName"].ToString() ,
                        DivisionName =Reader ["DivisionName"].ToString() 
                    };
                    subDisDistrictDivisionInfos.Add(aSubDisDistrictDivisionInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return subDisDistrictDivisionInfos;
        }

      /*  public  bool IsDuplicateDataExist(SubDistrictInfo aSubDistrictInfo)
        {

            string query = "SELECT * FROM SubDistrictInfo WHERE DistrictInfoId='" + aSubDistrictInfo.DistrictInfoId + "'";
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
*/
        public  int DeleteSubDistrict(int id)
        {
            int rowAffected = 0;
            string query = "DELETE FROM SubDistrictInfo WHERE Id='" + id + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public  List<SubDistrictInfo> GetAllSubDistrict()
        {
            List<SubDistrictInfo> aDistrictInfos = null;
            string query = "SELECT * FROM SubDistrictInfo ORDER BY Id DESC";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                aDistrictInfos = new List<SubDistrictInfo>();
                while (Reader.Read())
                {
                    SubDistrictInfo aDistrictInfo = new SubDistrictInfo();
                    aDistrictInfo.Id = (int)Reader["Id"];
                    aDistrictInfo.SubDistrictName  = Reader["SubDistrictName"].ToString();
                    aDistrictInfos.Add(aDistrictInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return aDistrictInfos;
        }
    }
}