<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageDonations.aspx.cs" Inherits="ClothesRecycling.ManageDonations" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="container">
 	   <div class="row headerContent">
        	<div class="col-sm-12">
            	<h1>&nbsp;</h1>
            	<h1>Manage Donations</h1>
        	</div>
    	</div>
    	<div class="row">
        	<div class="col-sm-12">
            	<h1>&nbsp;</h1>
 
            	<div>
                	<asp:GridView ID="gvManageDonations" runat="server" CaptionAlign="Top"
                    	AutoGenerateColumns="False" BackColor="White"
                    	BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"
                    	CellSpacing="2" CssClass="table table-hover table-striped" GridLines="None" OnRowCancelingEdit="gvManageDonations_RowCancelingEdit"
                    	OnRowDeleting="gvManageDonations_RowDeleting" OnRowEditing="gvManageDonations_RowEditing"
                    	OnRowUpdating="gvManageDonations_RowUpdating"
                    	EmptyDataText="There Are No Donations">
                    	<Columns>
                        	<asp:TemplateField HeaderText="Name">
                            	<ItemTemplate>
                                	<asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' />
                                	<asp:Label ID="lblDonationId" Visible="false" runat="server" Text='<%# Eval("DonationId") %>' />
                            	</ItemTemplate>
                        	</asp:TemplateField>
                        	<asp:TemplateField HeaderText="Pick up Locations">
                            	<ItemTemplate>
                                	<asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                            	</ItemTemplate>
                        	</asp:TemplateField>
                        	<asp:TemplateField HeaderText="Type of Clothes">
                            	<ItemTemplate>
                                	<asp:Label ID="lblClothesType" runat="server" Text='<%# Bind("DonationType") %>'></asp:Label>
                            	</ItemTemplate>
                        	</asp:TemplateField>
                        	<asp:TemplateField HeaderText="Pick Up Date">
                            	<ItemTemplate>
                                	<asp:Label ID="lblPickDate" runat="server" Text='<%# Eval("PickUpDate") %>'></asp:Label>
                            	</ItemTemplate>
                        	</asp:TemplateField>
                        	<asp:TemplateField HeaderText="Beneficiery">
                            	<ItemTemplate>
                                	<asp:Label ID="lblRecepient" runat="server" Text='<%# Bind("CharityName") %>'></asp:Label>
     	                       </ItemTemplate>
                            	<EditItemTemplate>
                                	<asp:DropDownList ID="DropDownList1" CssClass="form-control" onchange="SetStatusValue(this)" AppendDataBoundItems="true" runat="server" PreviousValue='<%# Eval("RecipientId") %>' SelectedValue='<%# Bind("RecipientId") %>' DataTextField="CharityName" DataValueField="RecipientId" DataSourceID="SqlDataSource1">
                                    	<asp:ListItem Value="">Select</asp:ListItem>
                                	</asp:DropDownList>
               	                 <asp:SqlDataSource ID="RecipientDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="Select RecipientId, CharityName from Recipient where Active=1" SelectCommandType="Text"></asp:SqlDataSource>
                            	</EditItemTemplate>
                        	</asp:TemplateField>
                        	<asp:TemplateField HeaderText="Status">
                            	<ItemTemplate>
                     	           <asp:Label ID="lblStatus" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                            	</ItemTemplate>
                            	<EditItemTemplate>
                                	<asp:DropDownList ID="ddlStatus" CssClass="form-control" SelectedValue='<%# Bind("Status") %>' runat="server">
                                    	<asp:ListItem Value="-1">--Select--</asp:ListItem>
                                    	<asp:ListItem Value="New Request">New Request</asp:ListItem>
                                    	<asp:ListItem Value="Allocated">Allocated</asp:ListItem>
                                    	<asp:ListItem Value="Picked Up">Picked Up</asp:ListItem>
                               	     <asp:ListItem Value="Delivered">Delivered</asp:ListItem>
                                	</asp:DropDownList>
                            	</EditItemTemplate>
                        	</asp:TemplateField>
                        	<asp:CommandField HeaderText="Edit/Delete" ShowDeleteButton="True"
                            	ShowEditButton="True" DeleteText="Delete" />
                    	</Columns>
                    	<EmptyDataRowStyle BackColor="#eeeeee" BorderColor="Black"
                        	BorderStyle="Solid" BorderWidth="1px" Font-Size="Large" ForeColor="#851010"
                        	HorizontalAlign="Center" />
                    	<FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
              	      <PagerStyle BackColor="#851010" ForeColor="Black" HorizontalAlign="Center" />
                    	<RowStyle BackColor="#EEEEEE" ForeColor="Black" HorizontalAlign="Left" />
                    	<SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    	<SortedAscendingCellStyle BackColor="#F1F1F1" />
                    	<SortedAscendingHeaderStyle BackColor="#0000A9" />
                    	<SortedDescendingCellStyle BackColor="#CAC9C9" />
 	                   <SortedDescendingHeaderStyle BackColor="#000065" />
                	</asp:GridView>
            	</div>
        	</div>
    	</div>
	</div>
 
<script src="Scripts/custom.js"></script>
</asp:Content>