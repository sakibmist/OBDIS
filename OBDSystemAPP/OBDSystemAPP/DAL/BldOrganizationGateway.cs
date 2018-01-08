using OBDSystemAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.DAL
{
    public class BldOrganizationGateway:DBConnection
    {
        
        public  bool IsExist(BldOrganizationInfo aInfo)
        {
            string query = "SELECT * FROM BldOrganizationInfo WHERE OrganizationName= '" + aInfo.OrganizationName + "' AND Address='" + aInfo.Address + "'AND Mobile='" + aInfo.Mobile + "' ";
            Connection.Open();
            Command = new SqlCommand(query,Connection);
            Reader = Command.ExecuteReader(); 
            if (Reader.HasRows)
            {
                return true;
            }
            Reader.Close();

            Connection.Close();
            return false;  
        }

        public  int SaveOrganizationInfo(Models.BldOrganizationInfo aInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO BldOrganizationInfo VALUES('" + aInfo.OrganizationName + "', '" + aInfo.Address + "', '" + aInfo.Mobile + "', '" + aInfo.Email + "','" + aInfo.DivisionInfoId + "','" + aInfo.DistrictInfoId + "', GETDATE() )";
            Connection.Open();
            Command = new SqlCommand(query,Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        } 
     

        public  List<OrganizationDistDivisionInfo> GetOrganizationDetail()
        {

            List<OrganizationDistDivisionInfo> bldOrganizationInfos = null;
            string query = "SELECT b.Id,b.OrganizationName,b.Address,b.Mobile,b.Email,d.DistrictName,div.DivisionName,b.CreatedAt FROM BldOrganizationInfo b JOIN DistrictInfo d ON d.Id=b.DistrictInfoId JOIN DivisionInfo div ON div.Id=b.DivisionInfoId";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<OrganizationDistDivisionInfo>();
                while (Reader.Read())
                {
                    OrganizationDistDivisionInfo bldOrganizationInfo = new OrganizationDistDivisionInfo
                    {
                        BldOrganizationInfoId = (int)Reader["Id"],
                        OrganizationName = Reader["OrganizationName"].ToString(),
                        Address = Reader["Address"].ToString(),
                        Mobile = Reader["Mobile"].ToString(),
                        Email = Reader["Email"].ToString(),
                        DistrictName = Reader["DistrictName"].ToString(),
                        DivisionName = Reader["DivisionName"].ToString(),
                        CreatedAt = (DateTime)Reader["CreatedAt"]
                    };
                    bldOrganizationInfos.Add(bldOrganizationInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return bldOrganizationInfos;
        }

        public  List<OrganizationDistDivisionInfo> GetOrganizationDetail(int  a, int  b)
        {

            List<OrganizationDistDivisionInfo> bldOrganizationInfos = null;
            string query = "SELECT b.OrganizationName,b.Address,b.Mobile,b.Email,d.DistrictName,div.DivisionName FROM BldOrganizationInfo b  JOIN DistrictInfo d  ON d.Id=b.DistrictInfoId JOIN DivisionInfo div  ON div.Id=b.DivisionInfoId  WHERE  d.Id='"+b+"' AND  div.Id='"+a+"'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<OrganizationDistDivisionInfo>();
                while (Reader.Read())
                {
                    OrganizationDistDivisionInfo bldOrganizationInfo = new OrganizationDistDivisionInfo
                    {
                         
                        OrganizationName = Reader["OrganizationName"].ToString(),
                        Address = Reader["Address"].ToString(),
                        Mobile = Reader["Mobile"].ToString(),
                        Email = Reader["Email"].ToString(),
                        DistrictName = Reader["DistrictName"].ToString(),
                        DivisionName = Reader["DivisionName"].ToString() 
                    };
                    bldOrganizationInfos.Add(bldOrganizationInfo);

                }
                Reader.Close();
            }
            Connection.Close();
            return bldOrganizationInfos;
        }

        public  int GetTotalNumberOfOrganization()
        {
            int totalNumberOfOrganization = 0;
            string query = " SELECT COUNT(*) FROM BldOrganizationInfo ";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            totalNumberOfOrganization = (int)Command.ExecuteScalar();
            Connection.Close();
            return totalNumberOfOrganization;
        }
    }
}