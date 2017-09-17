using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using BusinessObjects;

namespace ClothesRecycling
{
    public partial class GiveClothes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e) {
            int output = 0;
            BLL objBll = new BLL();
            Donation objDonation = new Donation();
            objDonation.Name = txtName.Value;
            objDonation.UserEmail = txtEmail.Value;
            objDonation.Address = txtAddress.Value;

            // pipe separation if both checkboxes checked
            if (chkReusable.Checked && chkNonReusable.Checked && chkNewClothes.Checked)
                objDonation.DonationType = chkReusable.Value + "|" + chkNonReusable.Value + "|" + chkNewClothes.Value;
            else if (chkReusable.Checked && chkNonReusable.Checked)
                objDonation.DonationType = chkReusable.Value + "|" + chkNonReusable.Value;
            else if (chkReusable.Checked && chkNewClothes.Checked)
                objDonation.DonationType = chkReusable.Value + "|" + chkNewClothes.Value;
            else if (chkNonReusable.Checked && chkNewClothes.Checked)
                objDonation.DonationType = chkNonReusable.Value + "|" + chkNewClothes.Value;
            else if (chkReusable.Checked)
                objDonation.DonationType = chkReusable.Value;
            else if (chkNonReusable.Checked)
                objDonation.DonationType = chkNonReusable.Value;
            else if (chkNewClothes.Checked)
                objDonation.DonationType = chkNewClothes.Value;

            objDonation.PickUpDate = dtPickupDate.Value;

            objDonation.Status = "New Request";

            output = objBll.GiveDonationBLL(objDonation);

            //If a row is affected then ie. Success condition will open a alert box for success else alert for error will be opened.
            if (output > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Donation Submitted Successfully');window.location.href = 'GiveClothes.aspx';", true);
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Error occurred');window.location.href = 'GiveClothes.aspx';", true);

            //ClientScript.RegisterStartupScript is used to call javascript function from the code behind side of the pages.
        }
    }

}