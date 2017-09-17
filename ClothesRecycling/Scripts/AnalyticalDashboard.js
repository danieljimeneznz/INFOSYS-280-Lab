$(document).ready(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'AnalyticalDashboard.aspx/GetDashboardData', // Pagename should be exactly same as your page name Analytical Dashboard in our case. GetDashboardData web method name should match with the web method name on AnalyticalDashboard.aspx.cs
        data: '{}',
        success:
        function (response) {
            drawVisualization(response.d);// On success drawVisualization function will be called.
        },
        failure:
        function (response) {
            alert("Error Occured while calling GetDashboardData web method");
        }
    });
})

function drawVisualization(dataValues) {
    for (var i = 0; i < dataValues.length; i++) {
        if (dataValues[i].ChartType == "PieChart") {
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Column Name');
            data.addColumn('number', 'Column Value');
            for (var j = 0; j < dataValues[i].lstData.length; j++) {
                data.addRow([dataValues[i].lstData[j].ColumnName, dataValues[i].lstData[j].Value]);
            }
            var drawPieChart = new google.visualization.PieChart(document.getElementById('dvPieChart'));
            drawPieChart.draw(data, { title: "Donation Status" });
        }
        if (dataValues[i].ChartType == "ColumnChart1") {

            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Donation Type');
            data.addColumn('number', 'Donation Value');
            for (var j = 0; j < dataValues[i].lstData.length; j++) {
                data.addRow([dataValues[i].lstData[j].ColumnName, dataValues[i].lstData[j].Value]);
            }
            var drawComboChart = new google.visualization.ColumnChart(document.getElementById('dvColumnChart1'));
            drawComboChart.draw(data, { title: "Donation Types" });
        }
        if (dataValues[i].ChartType == "ColumnChart2") {

            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Donations/Recepients');
            data.addColumn('number', 'Value');
            for (var j = 0; j < dataValues[i].lstData.length; j++) {
                data.addRow([dataValues[i].lstData[j].ColumnName, dataValues[i].lstData[j].Value]);
            }
            var drawComboChart = new google.visualization.ColumnChart(document.getElementById('dvColumnChart2'));
            drawComboChart.draw(data, { title: "Number of Donations and Recepients" });
        }
        if (dataValues[i].ChartType == "ColumnChart3") {

            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Dates');
            data.addColumn('number', 'Value');
            for (var j = 0; j < dataValues[i].lstData.length; j++) {
                data.addRow([dataValues[i].lstData[j].ColumnName, dataValues[i].lstData[j].Value]);
            }
            var drawComboChart = new google.visualization.ColumnChart(document.getElementById('dvColumnChart3'));
            drawComboChart.draw(data, { title: "Daywise Donations" });
        }
    }
}
