using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;

namespace ClothesRecycling {
    public partial class Signup : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSignUp_Click(object sender, EventArgs e) {
            int output;
            BLL objBLL = new BLL();

            //Step 1: Instantiate UserMaster from the BusinessObjects class and assign user inputs from the form to the object objUserMaster properties.
            UserMaster objUserMaster = new UserMaster();

            objUserMaster.FullName = txtFullName.Value;
            objUserMaster.UserEmail = txtEmail.Value;
            objUserMaster.Password = txtPassword.Value;
            objUserMaster.Active = 1;
            objUserMaster.UserRole = "User";

            //Step 2: Call the signup method of BLL(SignUpBLL)
            output = objBLL.SignUpBLL(objUserMaster);

            //Step 3: Display an alert box based on the output
            //If a row is affected (Success condition), alert box will be displayed for success else error message will be displayed.
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Registered successfully');window.location.href = 'Signin.aspx';", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Error occurred');window.location.href = 'Signup.aspx';", true);
        }
    }

}
