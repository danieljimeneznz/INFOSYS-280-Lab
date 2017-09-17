using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;

namespace ClothesRecycling
{
    public partial class Signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            UserMaster objUserMasterOutput = new UserMaster();

            UserMaster objUserMasterInput = new UserMaster();
            objUserMasterInput.UserEmail = txtEmail.Value;
            objUserMasterInput.Password = txtPassword.Value;

            BLL objBLL = new BLL();
            objUserMasterOutput = objBLL.SignInBLL(objUserMasterInput);

            // We are putting the entire output object objUserMasterOutput into the session variables so that all the user details
            // will be accessible throughout the application on all the pages.
            if (objUserMasterOutput != null)
            {
                Session["UserDetailsSession"] = objUserMasterOutput;
                Response.Redirect("UserDashboard.aspx");

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "UserNotFound", "alert('User not found.')", true);
            }
        }
    }
}