<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AnalyticalDashboard.aspx.cs" Inherits="ClothesRecycling.AnalyticalDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">
    <h1>&nbsp;</h1>
    <div class="row">
        <div class="col-md-6">
            <div id="dvPieChart" style="width: 600px; height: 350px;">
            </div>
        </div>
        <div class="col-md-4">
            <div id="dvColumnChart1" style="width: 600px; height: 350px;">
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div id="dvColumnChart2" style="width: 600px; height: 350px;">
            </div>
        </div>
        <div class="col-md-4">
            <div id="dvColumnChart3" style="width: 600px; height: 350px;">
            </div>
        </div>
    </div>
</div>
 
<%--#region Javascript files--%> 
<script type="text/javascript" src="//www.google.com/jsapi"></script>
<script src="Scripts/AnalyticalDashboard.js"></script>
<script type="text/javascript">
    google.load('visualization', '1', { packages: ['corechart'] });
</script>
<%--#endregion --%>
</asp:Content>
