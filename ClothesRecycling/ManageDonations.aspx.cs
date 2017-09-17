using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClothesRecycling
{
    public partial class ManageDonations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();

            }
        }

        protected void BindGrid()
        {
            try
            {
                BLL objBLL = new BLL();
                DataSet dsDonationsData = new DataSet();

                dsDonationsData = objBLL.GetDonationsDataBLL();

                gvManageDonations.DataSource = dsDonationsData;
                gvManageDonations.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        protected void gvManageDonations_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvManageDonations.EditIndex = -1;
            BindGrid();
        }

        protected void gvManageDonations_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int output = 0;
            GridViewRow row = gvManageDonations.Rows[e.RowIndex];
            Label lblDonationId = (Label)row.FindControl("lblDonationId");

            string DonationID = (lblDonationId != null && lblDonationId.Text != null && !string.IsNullOrEmpty(lblDonationId.Text)) ? lblDonationId.Text.Trim() : string.Empty;

            BLL objBLL = new BLL();
            output = objBLL.DeleteDonationBLL(DonationID);

            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "deleteDonations", "alert('Record Deleted Successfully')", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "deleteDonations", "alert('Error occurred')", true);

            BindGrid();


        }

        protected void gvManageDonations_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvManageDonations.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void gvManageDonations_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            BLL objBLL = new BLL();
            GridViewRow row = gvManageDonations.Rows[e.RowIndex];
            Label lblDonationId = (Label)row.FindControl("lblDonationId");
            DropDownList ddlStatus = (DropDownList)row.FindControl("ddlStatus");
            DropDownList ddlRecipient = (DropDownList)row.FindControl("ddlRecipient");
            string[] strArrUpdate = new string[4];

            strArrUpdate[0] = ddlRecipient.SelectedValue;
            strArrUpdate[1] = ddlStatus.SelectedValue;
            if (ddlRecipient.SelectedItem != null)
            {
                strArrUpdate[2] = ddlRecipient.SelectedItem.Text;
            }
            strArrUpdate[3] = lblDonationId.Text.Trim();



            int output = objBLL.AllocateRecepientBLL(strArrUpdate);
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "updaterecepient", "alert('Record Updated Successfully')", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "updaterecepient", "alert('Error occurred')", true);

            gvManageDonations.EditIndex = -1;
            BindGrid();
        }
    }
}
