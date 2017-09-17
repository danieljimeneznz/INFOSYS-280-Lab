using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BusinessLogicLayer;
using BusinessObjects;
using System.Web.Services; // required to write a web method.

namespace ClothesRecycling
{
    public partial class AnalyticalDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod] // This attribute is must to declare a web method.
        public static List<ChartData> GetDashboardData()// A web method is always a static method.
        {
            List<ChartData> objChartData = new List<ChartData>();
            BLL objBLL = new BLL();
            objChartData = objBLL.GetDataAnalyticsBLL();

            return objChartData;

        }
    }
}