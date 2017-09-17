using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using BusinessObjects;
using DataAccessLayer;

namespace BusinessLogicLayer {
    public class BLL {

        public int SignUpBLL(UserMaster objUserMaster) {
            int output;
            DAL objDal = new DAL();
            output = objDal.SignUpDAL(objUserMaster);
            return output;
        }

        public UserMaster SignInBLL(UserMaster objUserMaster)
        {
            UserMaster objUser = new UserMaster();
            DAL objDAL = new DAL();
            objUser = objDAL.SignInDAL(objUserMaster);
            return objUser;
        }

        public int GiveDonationBLL(Donation objDonation)
        {
            int output;
            DAL objDal = new DAL();
            output = objDal.GiveDonationDAL(objDonation);
            return output;

        }

        public int RegisterRecepientBLL(Recipient objRecipient)
        {
            DAL objDal = new DAL();
            int output;
            output = objDal.RegisterRecipientDAL(objRecipient);
            return output;
        }

        public DataSet GetDonationsDataBLL()
        {
            DataSet dsDonationsData = new DataSet();
            DAL objDal = new DAL();

            dsDonationsData = objDal.GetDonationsDataDAL();// call GetDonationsDataDAL method of DAL

            return dsDonationsData;
        }

        public int AllocateRecepientBLL(string[] strArrUpdate)
        {
            int output;
            DAL objDal = new DAL();

            output = objDal.AllocateRecepientDAL(strArrUpdate);
            return output;
        }

        public int DeleteDonationBLL(string DonationID)
        {
            int output;
            DAL objDal = new DAL();

            output = objDal.DeleteDonationDAL(DonationID);// call DeleteDonationDAL method of DAL
            return output;
        }

        public List<ChartData> GetDataAnalyticsBLL()
        {
            List<ChartData> output;
            DAL objDal = new DAL();

            output = objDal.GetDataAnalyticsDAL();// call DeleteDonationDAL method of DAL
            return output;

        }

    }
}
