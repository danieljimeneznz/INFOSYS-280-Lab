<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceiveClothes.aspx.cs" Inherits="ClothesRecycling.ReceiveClothes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    	<div class="row headerContent">
        	<div class="col-sm-12">
            	<h1>Register to Receive Clothes</h1>
        	</div>
    	</div>
    	<div class="row formContent">
        	<div class="col-sm-3"></div>
        	<div class="formContentLeft col-sm-3">
            	<div class="form-group">
                	<label for="txtCharityName">Charity Name</label>
                	<input type="text" class="form-control" id="txtCharityName" placeholder="Enter Charity Name" required="required" />
            	</div>
            	<div class="form-group">
                	<label for="txtCharityRegNum">Charity Registration Number</label>
                	<input type="text" class="form-control" id="txtCharityRegNum" placeholder="Enter Charity Registration Number" required="required" />
            	</div>
            	<div class="form-group">
                	<label for="txtEmail">Email Address</label>
          	      <input type="email" class="form-control" id="txtEmail" placeholder="Enter Email Address" required="required" />
            	</div>
        	</div>
        	<div class="formContentRight col-sm-3">
            	<div class="form-group">
                	<label for="txtContactNo">Contact Number</label>
                	<input type="text" class="form-control" id="txtContactNo" placeholder="Enter Phone number" required="required" />
            	</div>
            	<div class="form-group">
                	<label for="txtAddress">Address</label>
                	<textarea class="form-control" rows="6" id="txtAddress" placeholder="Enter Address" required="required"></textarea>
            	</div>
            	<div class="form-group">
                	<input type="submit" value="Register" class="btn btn-success btn-lg" />
            	</div>
        	</div>
        	<div class="col-sm-3"></div>
    	</div>
	</div>
</asp:Content>
