function validateDonationType()
{
    var chkDonationType = $("input[type='checkbox']:checked").length;
    if ($("input[id*='txtName']").val().trim() == "" || $("input[id*='txtAddress']").val().trim() == "") {// this condition we have added so that control returns true and form validates the empty value first and gives error
        return true;
    }
    //if Name and Address textboxes are filled then it will check if checkboxes are checked or not.
    if (chkDonationType > 0) {// if checked returns true so that OnClick event can be fired
        return true;
    }
    else {// if none of the checkbox is checked then give error and return false so that OnClick event written on GiveClothes.aspx.cs will not be fired until checkbox is checked.
        alert("Please select at least one Clothes Type");
        return false;
    }

}

//This function will be called from the on the 'onchnage' event of the ddlRecepient dropdown
function SetStatusValue(ddlObj)//ddlObj is the entire dropwdown object that will be passed from the ManageDonations.aspx , on the 'onchnage' event of the ddlRecepient dropdown
{
    var selectedVal = $(ddlObj).val();//Newly selected value of the dropdown ddlRecepient.
    var ddlRecptPreviousVal = $(ddlObj).attr("PreviousValue");// Storing the value of PreviousValue attribute into the variable.
    if (ddlRecptPreviousVal == '') {// check if the value is empty string i.e. the Select option of the dropdown.
        $(ddlObj).closest('tr').find('select[id *="ddlStatus"]').val("Allocated");// finding the Status dropdown ddlStatus from the row(tr) of the changed Recepient dropwdown ddlRecepient And set its value to Allocated.
        $(ddlObj).attr("PreviousValue", selectedVal);//Set the PreviousValue attribute of ddlRecepient dropdown to the newly selected value , so that this value will be useful to track the onchange event next time.
    }
    else {//if the value is NOT the empty string i.e NOT the Select option of the dropdown.
        $(ddlObj).attr("PreviousValue", selectedVal); //Set the PreviousValue attribute of ddlRecepient dropdown to the newly selected value , so that this value will be useful to track the onchange event next time.
    }
}
