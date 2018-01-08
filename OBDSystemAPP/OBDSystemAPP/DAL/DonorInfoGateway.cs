using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OBDSystemAPP.Models;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.DAL
{
    public class DonorInfoGateway : DBConnection
    {
        public bool IsExistData(DonorInfo aDonorInfo)
        {
            string query = "SELECT * FROM DonorInfo WHERE Mobile='" + aDonorInfo.Mobile + "' AND DonorUserId='" + aDonorInfo.DonorUserId + "' ";
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

        public int SaveDonorInfo(DonorInfo aDonorInfo)
        {
            int rowAffected = 0;
            string query = "INSERT INTO DonorInfo VALUES('" + aDonorInfo.DonorName + "','" + aDonorInfo.DonorType +
                           "','" + aDonorInfo.FatherName + "','" + aDonorInfo.MotherName + "','" +
                           aDonorInfo.BloodInfoId + "','" + aDonorInfo.Gender + "','" + aDonorInfo.Dob + "','" +
                           aDonorInfo.Mobile + "','" + aDonorInfo.AlterMobile + "', '" + aDonorInfo.Email + "' ,'" +
                           aDonorInfo.DivisionInfoId + "','" + aDonorInfo.DistrictInfoId + "','" +
                           aDonorInfo.SubDistrictInfoId + "','" + aDonorInfo.City + "','" + aDonorInfo.DonorUserId +
                           "','" + aDonorInfo.DonorPassword + "','" + aDonorInfo.AbilityToDonate + "','" +aDonorInfo .PublishStatus + "')";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        } 
        public bool IsMatch(string a, string b)
        {
            string query = "SELECT * FROM DonorInfo WHERE DonorUserId='" + a + "' AND DonorPassword='" + b + "' ";
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

        public List<DonorDetailInfoForSearch> GetDonorDetail(int a, int b, int c, int d, string es,string publishStatus)
        { 
            List<DonorDetailInfoForSearch> bldOrganizationInfos = null;
            string query =" SELECT do.Id,do.DonorName,b.BloodGroupName,do.Mobile,do.AlterMobile,do.Email,do.City,s.SubDistrictName,d.DistrictName,div.DivisionName FROM DonorInfo do JOIN DistrictInfo d ON d.Id=do.DistrictInfoId JOIN DivisionInfo div ON div.Id=do.DivisionInfoId JOIN BloodInfo b ON b.Id=do.BloodInfoId JOIN SubDistrictInfo s ON s.Id=do.SubDistrictInfoId  WHERE  div.Id='" +
                a + "' AND d.Id='" + b + "' AND b.Id='" + c + "' AND s.Id='" + d + "' AND do.AbilityToDonate='" + es + "' AND do.PublishStatus='" + publishStatus + "' ";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<DonorDetailInfoForSearch>();
                while (Reader.Read())
                {
                    DonorDetailInfoForSearch bldOrganizationInfo = new DonorDetailInfoForSearch
                    {
                        DonorId = (int)Reader["Id"],
                        DonorName = Reader["DonorName"].ToString(),
                        BloodGroupName = Reader["BloodGroupName"].ToString(),
                        Mobile = Reader["Mobile"].ToString(),
                        AlterMobile = Reader["AlterMobile"].ToString(),
                        Email = Reader["Email"].ToString(),
                        City = Reader["City"].ToString(),
                        SubDistrictName = Reader["SubDistrictName"].ToString(),
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

        public List<DonorProfileInfo> GetAllDonorInfo(string donorUserId)
        {
            List<DonorProfileInfo> bldOrganizationInfos = null;
            string query = "SELECT d.Id,d.DonorName,d.DonorType,d.FatherName,d.MotherName,b.BloodGroupName,d.Gender,d.Dob,d.Mobile,d.AlterMobile,d.Email,d.DonorUserId,d.DonorPassword,d.AbilityToDonate,d.City,sdis.SubDistrictName,dis.DistrictName,div.DivisionName FROM DonorInfo d JOIN BloodInfo b ON b.Id=d.BloodInfoId JOIN DivisionInfo div ON div.Id=d.DivisionInfoId JOIN DistrictInfo dis ON dis.Id=d.DistrictInfoId JOIN SubDistrictInfo sdis ON sdis.Id=d.SubDistrictInfoId WHERE d.DonorUserId='" + donorUserId + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<DonorProfileInfo>();
                while (Reader.Read())
                {
                    DonorProfileInfo bldOrganizationInfo = new DonorProfileInfo
                    {
                        DonorId = (int) Reader["Id"],
                        DonorName = Reader["DonorName"].ToString(),
                        DonorType = Reader["DonorType"].ToString(),
                        FatherName = Reader["FatherName"].ToString(),
                        MotherName = Reader["MotherName"].ToString(),
                        BloodGroupName = Reader["BloodGroupName"].ToString(),
                        Gender = Reader["Gender"].ToString(),
                        Dob = Convert.ToDateTime(Reader["Dob"]),
                        Mobile = Reader["Mobile"].ToString(),
                        AlterMobile = Reader["AlterMobile"].ToString(),
                        Email = Reader["Email"].ToString(),
                        DonorUserId = Reader["DonorUserId"].ToString(),
                        DonorPassword = Reader["DonorPassword"].ToString(),
                        AbilityToDonate = Reader["AbilityToDonate"].ToString(),
                        City = Reader["City"].ToString(),
                        SubDistrictName = Reader["SubDistrictName"].ToString(),
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

        public DonorInfo GetDataUpdById(int donorId)
        {
            DonorInfo aDonorInfo = null;
            string query = "SELECT * FROM DonorInfo WHERE Id='" + donorId + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                    aDonorInfo= new DonorInfo{
             
                        DonorName = Reader["DonorName"].ToString(),
                        DonorType = Reader["DonorType"].ToString(),
                        FatherName = Reader["FatherName"].ToString(),
                        MotherName = Reader["MotherName"].ToString(),
                        BloodInfoId = (int) Reader["BloodInfoId"],
                        Gender = Reader["Gender"].ToString(),
                        Dob = Convert.ToDateTime(Reader["Dob"]),
                        Mobile = Reader["Mobile"].ToString(),
                        AlterMobile = Reader["AlterMobile"].ToString(),
                        Email = Reader["Email"].ToString(),
                        DivisionInfoId = (int) Reader["DivisionInfoId"],
                        DistrictInfoId = (int) Reader["DistrictInfoId"],
                        SubDistrictInfoId = (int) Reader["SubDistrictInfoId"],
                        City = Reader["City"].ToString(),
                        DonorUserId = Reader["DonorUserId"].ToString(),
                        DonorPassword = Reader["DonorPassword"].ToString(),
                        AbilityToDonate=Reader["AbilityToDonate"].ToString() 
                    };
                    Reader.Close(); 
                } 
                Connection.Close();
               return aDonorInfo;
            } 

        public  int UpdateDonorInfoCheck(DonorInfo aDonorInfo)
        {
            int rowAffected = 0;
            string query = "UPDATE DonorInfo SET DonorName='" + aDonorInfo.DonorName + "',DonorType='" + aDonorInfo.DonorType + "',FatherName='" + aDonorInfo.FatherName + "',MotherName='" + aDonorInfo.MotherName + "',BloodInfoId='" + aDonorInfo.BloodInfoId + "', Gender='" + aDonorInfo.Gender + "', Dob='" + aDonorInfo.Dob + "',Mobile='" + aDonorInfo.Mobile + "', AlterMobile='" + aDonorInfo.AlterMobile + "',Email= '" + aDonorInfo.Email + "', DivisionInfoId='" + aDonorInfo.DivisionInfoId + "', DistrictInfoId='" + aDonorInfo.DistrictInfoId + "',SubDistrictInfoId='" + aDonorInfo.SubDistrictInfoId + "',City='" + aDonorInfo.City + "',DonorUserId='" + aDonorInfo.DonorUserId + "',DonorPassword='" + aDonorInfo.DonorPassword + "',AbilityToDonate='" + aDonorInfo.AbilityToDonate + "' WHERE Id='"+aDonorInfo .Id  +"'";
            Connection .Open();
            Command = new SqlCommand(query, Connection); 
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close(); 
            return rowAffected; 
        }



        public List<DonorDetailInfoForSearch> GetDonorDetail(string  publishStatus)
        {
            List<DonorDetailInfoForSearch> bldOrganizationInfos = null;
            string query = " SELECT do.Id,do.DonorName,b.BloodGroupName,do.Mobile,do.AlterMobile,do.Email,s.SubDistrictName,d.DistrictName,div.DivisionName FROM DonorInfo do JOIN DistrictInfo d ON d.Id=do.DistrictInfoId JOIN DivisionInfo div ON div.Id=do.DivisionInfoId JOIN BloodInfo b ON b.Id=do.BloodInfoId JOIN SubDistrictInfo s ON s.Id=do.SubDistrictInfoId WHERE do.PublishStatus= '" + publishStatus + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<DonorDetailInfoForSearch>();
                while (Reader.Read())
                {
                    DonorDetailInfoForSearch bldOrganizationInfo = new DonorDetailInfoForSearch
                    {
                        DonorId = (int)Reader ["Id"],
                        DonorName = Reader["DonorName"].ToString(),
                        BloodGroupName = Reader["BloodGroupName"].ToString(),
                        Mobile = Reader["Mobile"].ToString(),
                        AlterMobile = Reader["AlterMobile"].ToString(),
                        Email = Reader["Email"].ToString(), 
                        SubDistrictName = Reader["SubDistrictName"].ToString(),
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

        public int GetNumberOfDonor()
        {
            int totalNumberOfDonor = 0;
            string query = " SELECT COUNT(*) FROM DonorInfo "; 
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            totalNumberOfDonor = (int)Command.ExecuteScalar();
            Connection.Close();
            return totalNumberOfDonor;
        }


        public  DonorInfo GetDonorDataById(int id)
        {
            DonorInfo aDonorInfo = null;
            string query = "SELECT * FROM DonorInfo WHERE Id='" + id + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                aDonorInfo = new DonorInfo
                { 
                    PublishStatus = Reader["PublishStatus"].ToString()
                };
                Reader.Close();
            } 
            Connection.Close();
            return aDonorInfo;
        }

        public  int UpdatePublishInfo(DonorInfo aDonorInfo)
        { 
            int rowAffected = 0;
            string query = "UPDATE DonorInfo SET PublishStatus='" + aDonorInfo.PublishStatus + "' WHERE Id='" + aDonorInfo.Id + "'";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;  
        }

        public  List<DonorDetailInfoForSearch> GetMostDonorInfo()
        {
            List<DonorDetailInfoForSearch> bldOrganizationInfos = null;
            string query = " SELECT do.DonorName,do.DonorType,b.BloodGroupName,do.Mobile,s.SubDistrictName,d.DistrictName,div.DivisionName,do.AbilityToDonate,do.PublishStatus FROM DonorInfo do JOIN DistrictInfo d ON d.Id=do.DistrictInfoId JOIN DivisionInfo div ON div.Id=do.DivisionInfoId JOIN BloodInfo b ON b.Id=do.BloodInfoId JOIN SubDistrictInfo s ON s.Id=do.SubDistrictInfoId ";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                bldOrganizationInfos = new List<DonorDetailInfoForSearch>();
                while (Reader.Read())
                {
                    DonorDetailInfoForSearch bldOrganizationInfo = new DonorDetailInfoForSearch
                    {
                        DonorName = Reader["DonorName"].ToString(),
                        DonorType = Reader["DonorType"].ToString(),
                        BloodGroupName = Reader["BloodGroupName"].ToString(),
                        Mobile = Reader["Mobile"].ToString(),
                        SubDistrictName = Reader["SubDistrictName"].ToString(),
                        DistrictName = Reader["DistrictName"].ToString(),
                        DivisionName = Reader["DivisionName"].ToString(),
                        AbilityToDonate = Reader["AbilityToDonate"].ToString(),
                        PublishStatus = Reader["PublishStatus"].ToString()
                    };
                    bldOrganizationInfos.Add(bldOrganizationInfo); 
                }
                Reader.Close();
            }
            Connection.Close();
            return bldOrganizationInfos;
        }

        public  int DeleteById(int id)
        { 
            int rowAffected = 0;
            string query = "DELETE FROM DonorInfo WHERE Id='"+id+"'";
            Connection .Open();
            Command = new SqlCommand(query, Connection);
            rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public int GetNumberOfPendingDonor(string  status)
        {
            int numberOfPendingDonor = 0;
            string query = "SELECT COUNT(*) FROM DonorInfo WHERE PublishStatus='"+status+"' ";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            numberOfPendingDonor = Convert .ToInt32( Command.ExecuteScalar());
            Connection.Close();
            return numberOfPendingDonor;
        }
    } 

    }
