<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Signup.aspx.cs" Inherits="ClothesRecycling.Signup" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Sign Up - Recycle Clothes</title>
	<link href="Content/theme.css" rel="stylesheet" />
	<link href="Content/custom.css" rel="stylesheet" />
<style>
    .logo {
    padding-top:70px;
    padding-bottom:50px;
    text-align: center;
}
</style>

</head>
<body>
	<div class="container">
    	<div class="row">
        	<div class="col-sm-4"></div>
        	<div class="logo col-sm-4">
            	<img src="images/logo.png" width="200" />
        	</div>
        	<div class="col-sm-4"></div>
    	</div>
    	<div class="row">
        	<div class="form col-sm-6">
            	<form id="frmSignUp" runat="server">
                	<div>
                    	<h2>Sign Up</h2>
                    	<div class="form-group">
                        	<label for="textFullName">Full Name</label>
                        	<input type="text" id="txtFullName" placeholder="Enter Full Name" class="form-control" required="required" runat="server" />
                    	</div>
                    	<div class="form-group">
                        	<label for="txtEmail">Email</label>
 
                        	<input type="email" id="txtEmail" placeholder="Enter Email Address" class="form-control" required="required" runat="server" />
                    	</div> 
                    	<div class="form-group">
                        	<label for="txtPassword">Password</label>
 
                        	<input type="password" id="txtPassword" placeholder="Select secure password" class="form-control" required="required" runat="server" />
                    	</div>
                    	<div class="form-group">
                        	<asp:button ID="btnSignUp" Text="Submit" CssClass="btn btn-success" runat="server" OnClick="btnSignUp_Click"/>
                    	</div>
                    	<p>Existing User? <a href="Signin.aspx">Sign In!</a></p>
                	</div>
           	 </form> 
        	</div>
        	<div class="content col-sm-6">
      	      <h2>Your waste is someone's need!</h2>
            	<p>
                	Recycle the lifecycle !
            	</p>
            	<div style="position: relative; height: 0; padding-bottom: 75.0%">
                	<iframe src="https://www.youtube.com/embed/or9JgT6LhKI?ecver=2" width="480" height="360" style="position: absolute; width: 100%; height: 100%; left: 0"></iframe>
            	</div>
        	</div>
    	</div>
	</div>
</body>
</html>