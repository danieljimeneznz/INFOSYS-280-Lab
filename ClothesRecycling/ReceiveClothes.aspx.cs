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
    public partial class ReceiveClothes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int output = 0;
            BLL objBLL = new BLL();

            Recipient objRecipient = new Recipient();
            objRecipient.CharityName = txtCharityName.Value;
            objRecipient.Email = txtEmail.Value;
            objRecipient.RegNumber = txtCharityRegNum.Value;
            if (txtContactNo.Value != null && !string.IsNullOrEmpty(txtContactNo.Value))
            {
                objRecipient.PhoneNo = txtContactNo.Value.Trim();
            }
            objRecipient.Address = txtAddress.Value;
            objRecipient.Active = 1;

            output = objBLL.RegisterRecepientBLL(objRecipient);
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "registerSuccess", "alert('Charity Registered Successfully');window.location.href = 'ReceiveClothes.aspx';", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "registerError", "alert('Error occurred');window.location.href = 'ReceiveClothes.aspx';", true);
        }
    }
}