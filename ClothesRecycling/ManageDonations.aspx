<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageDonations.aspx.cs" Inherits="ClothesRecycling.ManageDonations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
   	<h1>Manage Donations</h1>
   </div>
   <div class="container">
   	<div class="row">
       	<div class="col-m-12">
           	<h2>&nbsp;</h2>
           	<div>
               	<table class="table table-hover">
   	                   	<thead>
   	                       	<tr>
   	                           	<th>Name</th>
   	                           	<th>Pick up Locations</th>
   	                           	<th>Type of Clothes</th>
   	                           	<th>Date</th>
   	                           	<th>Beneficiary</th>
   	                           	<th>Status</th>
   	                       	</tr>
   	                   	</thead>
   	                   	<tbody>
   	                       	<tr>
   	    	                       <td>John</td>
   	                           	<td>Doe</td>
   	                           	<td>Reusable</td>
   	                           	<td>02/03/2017</td>
   	                           	<td>
   	                               	<select id="selectbasic" name="selectbasic" class="form-control">
   	                                   	<option value="0" selected>Select</option>
   	                                   	<option value="1">Option one</option>
   	                                   	<option value="2">Option two</option>
   	                               	</select></td>
   	                           	<td>New Request</td>
   	                       	</tr>
   	                       	<tr>
   	                           	<td>Mary</td>
   	                           	<td>Moe</td>
   	                           	<td>Non Reusable </td>
   	                           	<td>06/10/2017</td>
   	                           	<td>Orphanage</td>
   	                               <td>Allocated</td>
   	                       	</tr>
   	                       	<tr>
   	                           	<td>July</td>
   	                           	<td>Dooley</td>
   	                           	<td>New</td>
   	                           	<td>7/06/2017</td>
   	                           	<td>Orphanage</td>
   	                           	<td>Picked up</td>
   	                       	</tr>
   	                       	<tr>
   	         	                  <td>Mary</td>
   	                           	<td>Moe</td>
   	                           	<td>Reusable</td>
   	                           	<td>06/10/2017</td>
   	                           	<td>Orphanage</td>
   	                           	<td>Delivered</td>
   	                       	</tr>
   	                       	<tr>
   	                           	<td>Mary</td>
   	                           	<td>Moe</td>
   	                           	<td>Non Reusable</td>
   	                           	<td>06/10/2017</td>
   	                           	<td>Orphanage</td>
   	                           	<td>Cancelled</td>
   	                       	</tr>
   	                   	</tbody>
   	        	       </table>
   	           	</div>
   	       	</div>
   	   	</div>
   	   </div
</asp:Content>
