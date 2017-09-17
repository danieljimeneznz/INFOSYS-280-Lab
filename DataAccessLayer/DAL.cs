using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        public string ConnectionString = string.Empty;

        public DAL() {
            ConnectionString = ConfigurationManager.ConnectionStrings["RecyclingClothesDB"].ConnectionString;
        }
    }
}
