using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer {
    public class DAL {
        public string ConnectionString = string.Empty;

        public DAL() {
            ConnectionString = ConfigurationManager.ConnectionStrings["RecyclingClothesDB"].ConnectionString;
        }

        public int SignUpDAL(UserMaster objUserMaster)
        {
            int output = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sql = string.Format(@"INSERT INTO [UserMaster] (FullName, UserEmail, Password, Active, UserRole) VALUES ('{0}','{1}','{2}','{3}','{4}')", 
                objUserMaster.FullName, objUserMaster.UserEmail, objUserMaster.Password, objUserMaster.Active, objUserMaster.UserRole);
            SqlCommand command = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                // ExecuteNonQuery() is Used to execute the insert command. 
                // This inserts the data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return output;
        }

        /// <summary>
        /// To handle DB null Values
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="columnName"></param>
        /// <returns>string columnValue</returns>
        public string GetColumnValue(SqlDataReader dr, string columnName)
        {
            string columnValue = string.Empty;
            if (dr[columnName] != null && dr[columnName] != DBNull.Value)
            {
                columnValue = dr[columnName].ToString();
            }
            return columnValue;
        }

        public UserMaster SignInDAL(UserMaster objUserMaster)
        {
            UserMaster objUser = null; /*new UserMaster();*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sql = string.Format(@"SELECT TOP 1 * FROM [UserMaster] WHERE UserEmail='{0}' AND Password ='{1}' AND Active= 1",
                objUserMaster.UserEmail, objUserMaster.Password);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                // Used to execute the query to validate the entered details (email and password) and returns a corresponding row if user is valid and present in DB.
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    objUser = new UserMaster();
                    if (dr.Read())
                    {
                        // Calling GetColumnValue method to handle null values and retrieve the data from dr object and assign it to objUser variables without exceptions.
                        objUser.FullName = GetColumnValue(dr, "FullName");
                        objUser.UserEmail = GetColumnValue(dr, "UserEmail");
                        objUser.UserRole = GetColumnValue(dr, "UserRole");
                        objUser.Active = Convert.ToInt16(GetColumnValue(dr, "Active"));
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return objUser;
        }

        public int GiveDonationDAL(Donation objDonation)
        {
            int output = 0;
            if (objDonation != null)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string sql = string.Format(@"INSERT INTO [Donation] (Name, UserEmail, Address , DonationType, PickUpDate, Status) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                              objDonation.Name, objDonation.UserEmail, objDonation.Address, objDonation.DonationType, objDonation.PickUpDate, objDonation.Status);
                SqlCommand command = new SqlCommand(sql, connection);
                try
                {

                    connection.Open();
                    // Used to execute the insert command. This inserts the Donation data into the DB.
                    output = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }

            }
            return output;
        }

        public int RegisterRecipientDAL(Recipient objRecipient)
        {
            int output = 0;
            if (objRecipient != null)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                string sql = string.Format(@"INSERT INTO [Recipient] (CharityName, Email, RegNumber , PhoneNo, Address, Active)
                                	VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                    objRecipient.CharityName, objRecipient.Email, objRecipient.RegNumber, objRecipient.PhoneNo,
                                    objRecipient.Address, objRecipient.Active);
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    // Used to execute the insert command. This inserts the Donation data into the DB.
                    output = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return output;
        }

        public DataSet GetDonationsDataDAL()
        {
            DataSet dsDonationsData = new DataSet();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string cmd = "Select * from [Donation] order by PickUpDate ASC";
            SqlCommand command = new SqlCommand(cmd, connection);

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);// Used to execute the select command.
                adapter.Fill(dsDonationsData);// Fill the dataset dsDonationsData from the sql adapter.
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dsDonationsData; // return the entire dataset.

        }

        public int AllocateRecepientDAL(string[] strArrUpdate)
        {
            int output;

            SqlConnection connection = new SqlConnection(ConnectionString);


            string sql = string.Format(@"update [Donation] set RecipientId = '{0}', Status = '{1}', CharityName='{2}' where DonationId ='{3}'",
                strArrUpdate[0], strArrUpdate[1], strArrUpdate[2], strArrUpdate[3]);

            //string sql = "update [Donations] set RecipientId = " + Convert.ToInt32(strArrUpdate[2]) + ", Status = '" + strArrUpdate[1] + "', CharityName='" + strArrUpdate[3] + "' where DonationId = " + Convert.ToInt32(strArrUpdate[0]) + "";

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {

                connection.Open();
                // Used to execute the insert command. This inserts the Donation data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return output;
        }

        public int DeleteDonationDAL(string DonationID)
        {
            int output;

            SqlConnection connection = new SqlConnection(ConnectionString);


            SqlCommand command = new SqlCommand(@"delete from [Donation] where  DonationId =" + DonationID + "", connection);
            try
            {

                connection.Open();
                // Used to execute the insert command. This inserts the Donation data into the DB.
                output = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return output;
        }

        public List<Data> GetIndividualChartData(DataTable dt)
        {
            List<Data> dataList = new List<Data>();
            string ColumnName = "";
            int val = 0;
            foreach (DataRow dr in dt.Rows)
            {

                if (dr[0].GetType().Name == "DateTime")
                {
                    DateTime dtTime;
                    DateTime.TryParse(dr[0].ToString(), out dtTime);

                    ColumnName = dtTime.ToShortDateString();
                }
                else
                    ColumnName = dr[0].ToString();


                val = Convert.ToInt32(dr[1]);
                dataList.Add(new Data(ColumnName, val));
            }
            return dataList;
        }


        public List<ChartData> GetDataAnalyticsDAL()
        {
            List<ChartData> lstChartData = new List<ChartData>();

            DataSet ds = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string cmd1 = "select Status, count(DonationId)  'Number of Donations' from Donation group by Status";
                using (SqlCommand cmd = new SqlCommand(cmd1, cn))
                {
                    ds = new DataSet();

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "PieChart", lstData = dataList });
                }

                string cmd2 = "select DonationType, count(DonationId)  'Number of Donations' from Donation group by DonationType";//select DonationType, CharityName, count(DonationId)  'Number of Donations' from Donations group by DonationType, CharityName
                using (SqlCommand cmd = new SqlCommand(cmd2, cn))
                {

                    ds = new DataSet();
                    dt.Clear();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "ColumnChart1", lstData = dataList });
                }

                string cmd3 = @"select'Number of Donations', count(DonationId) from Donation
                            	union all
                           	select 'Number of Recipients', count(RecipientId) from Recipient";
                using (SqlCommand cmd = new SqlCommand(cmd3, cn))
                {

                    ds = new DataSet();
                    dt.Clear();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "ColumnChart2", lstData = dataList });
                }

                string cmd4 = "select CONVERT(date, CreatedDate) 'Dates', count(DonationId) 'Number of Donations' from Donation group by CONVERT(date, CreatedDate)";
                using (SqlCommand cmd = new SqlCommand(cmd4, cn))
                {

                    ds = new DataSet();
                    dt.Clear();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    List<Data> dataList = GetIndividualChartData(dt);
                    lstChartData.Add(new ChartData() { ChartType = "ColumnChart3", lstData = dataList });
                }

            }


            return lstChartData;

        }

    }
}
