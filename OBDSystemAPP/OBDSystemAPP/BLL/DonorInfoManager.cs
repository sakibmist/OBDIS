using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OBDSystemAPP.DAL;
using OBDSystemAPP.Models;
using OBDSystemAPP.ViewModels;

namespace OBDSystemAPP.BLL
{
    public class DonorInfoManager
    {
        private DonorInfoGateway _donorInfoGateway = new DonorInfoGateway();

        public string SaveDonorInfo(DonorInfo aDonorInfo)
        {
             bool isDuplicateData = _donorInfoGateway.IsExistData(aDonorInfo);
            if (!isDuplicateData)
            {
            int rowAffected = _donorInfoGateway.SaveDonorInfo(aDonorInfo);
            if (rowAffected > 0)
            {
                return "success";
            }
            else
            {
                return "failed";
            }
            }
            else
            {
                return "exist";
            }


        }

        public  string IsMatch(string a, string b)
        {
            bool isMatch = _donorInfoGateway.IsMatch(a, b);
            if (isMatch)
            {
                return "success";
            }
            else
            {
                return "failed";
            }
        }

        public  List<ViewModels.DonorDetailInfoForSearch> GetDonorDetail(int a, int b, int c, int d, string es, string  publishStatus)
        {
            return _donorInfoGateway.GetDonorDetail(a,b,c,d,es,publishStatus);
        }

        public List<DonorProfileInfo> GetAllDonorInfo(string donorUserId)
        {
            return _donorInfoGateway.GetAllDonorInfo(donorUserId);
        }

        public  DonorInfo GetDonorUpdateDataById(int donorId)
        {
            return _donorInfoGateway.GetDataUpdById(donorId);
        }



        public  string UpdateDonorInfo(DonorInfo aDonorInfo)
        {
            
                int rowAffected = _donorInfoGateway.UpdateDonorInfoCheck(aDonorInfo);
                if (rowAffected > 0)
                {
                    return "update";
                }
                else
                {
                    return "failed";
                }
             
          
           
        }



        public List<DonorDetailInfoForSearch> GetDonorDetail(string  publishStatus)
        {
            return _donorInfoGateway.GetDonorDetail(publishStatus);
        }

        public  int GetNumberOfDonor()
        {
            return _donorInfoGateway.GetNumberOfDonor();
        }



        public  DonorInfo GetDonorDataById(int id)
        {
            return _donorInfoGateway.GetDonorDataById(id);
        }

        public  string UpdatePublishInfo(DonorInfo aDonorInfo)
        {
           int rowAffected= _donorInfoGateway.UpdatePublishInfo(aDonorInfo);
             if (rowAffected > 0)
                {
                    return "update";
                }
                else
                {
                    return "failed";
                }
        }

        public  List<DonorDetailInfoForSearch> GetMostDonorInfo()
        {
            return _donorInfoGateway.GetMostDonorInfo();
        }

        public  string DeleteById(int id)
        {
            int rowAffected = _donorInfoGateway.DeleteById(id);
            if (rowAffected > 0)
            {
                return "delete";
            }
            else
            {
                return "failed";
            }
        }

        public int GetNumberOfPendingDonor(string status)
        {
            return _donorInfoGateway.GetNumberOfPendingDonor(status);
        }
    }
}