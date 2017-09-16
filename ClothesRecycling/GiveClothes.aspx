<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GiveClothes.aspx.cs" Inherits="ClothesRecycling.GiveClothes" %>

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
            	<p>Don't throw away the clothes you don’t want. Let us look after your waste to fulfil someone's need!</p>
        	</div>
        	<div class="col-sm-6">
            	<div class="form-group">
                	<label for="txtName" class="control-label">Name</label>
                	<input type="text" placeholder="Enter Name" class="form-control" id="txtName" />
            	</div>
            	<div class="form-group">
                	<label for="txtEmail" class="control-label">Email</label>
                	<input type="email" placeholder="Enter Email" class="form-control" id="txtEmail" />
            	</div>
            	<label for="checkClothes" class="control-label">Type of Clothes</label>
            	<div class="checkbox">
                	<label>
                    	<input type="checkbox" value="Reusable">Reusable</label>
            	</div>
            	<div class="checkbox">
                	<label>
      	              <input type="checkbox" value="Non Reusable">Non Reusable</label>
            	</div>
            	<div class="checkbox">
                	<label>
                    	<input type="checkbox" value="Brand New">Brand New</label>
            	</div>
            	<div class="form-group">
                	<label for="txtDate" class="control-label">Pickup Date</label>
 
                	<input type="date" class="form-control" id="txtDate" />
            	</div>
     	       <div class="form-group">
                	<input type="submit" value="Submit" class="btn btn-success btn-lg" />
                	<input type="button" value="Reset" class="btn btn-danger btn-lg" />
            	</div>
        	</div>
    </div>
</div>
</asp:Content>
