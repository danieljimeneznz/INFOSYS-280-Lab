<%@ Page Title="Give Clothes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GiveClothes.aspx.cs" Inherits="ClothesRecycling.GiveClothes" %> 
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="container">
    	<div class="row">
        	<div class="col-sm-12">
            	<h1>A small donation can go a long way!</h1>
        	</div>
    	</div>
    	<div class="row">
        	<div class="col-sm-6">
            	<h2>Give Clothes</h2>
            	<p>Dont throw away the clothes you dont want. Let us look after your waste to fullfil someones need!</p>
            </div>
        	<div class="col-sm-6">
            	<div class="form-group">
                	<label for="txtName" class="control-label">Name</label>
                	<input type="text" placeholder="Enter Name" class="form-control" id="txtName" runat="server" />
            	</div>
            	<div class="form-group">
                	<label for="txtEmail" class="control-label">Email</label>
                	<input type="email" placeholder="Enter Email" class="form-control" id="txtEmail" runat="server" />
            	</div>
            	<div class="form-group">
                	<label for="txtAddress" class="control-label">Address</label>
                	<input type="text" placeholder="Enter Address" class="form-control" id="txtAddress" runat="server" />
            	</div>
 
            	<label for="chxClothes" class="control-label">Type of Clothes</label>
            	<div class="checkbox">
                	<label>
                    	<input type="checkbox" value="Reusable" id="chkReusable" runat="server">Reusable</label>
            	</div>
            	<div class="checkbox">
                	<label>
                    	<input type="checkbox" value="Non Reusable" id="chkNonReusable" runat="server">Non Reusable</label>
            	</div>
            	<div class="checkbox">
                	<label>
                    	<input type="checkbox" value="Brand New" id="chkNewClothes" runat="server">Brand New</label>
            	</div>
            	<div class="form-group">
                	<label for="txtDate" class="control-label">Pickup Date</label>
                	<input type="date" class="form-control" id="dtPickupDate" runat="server" />
  	          </div>
            	<div class="form-group">
                	<asp:Button ID="btnSubmit" OnClientClick="return validateDonationType();" OnClick="btnSubmit_Click" runat="server" CssClass="btn btn-primary" Text="Submit" />
                	<asp:Button ID="btnReset" OnClientClick="window.location.href='GiveClothes.aspx'; return false;" runat="server" CssClass="btn btn-primary" Text="Reset" />
            	</div>
        	</div>
    	</div>
	</div>
<script src="Scripts/custom.js"></script>
</asp:Content>