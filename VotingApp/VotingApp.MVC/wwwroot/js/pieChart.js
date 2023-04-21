google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(drawChart);

// Draw the chart and set the chart values
function drawChart(data,elementId) {
    let array = [
        ['Task', 'Hours per Day']
    ]

    for (const item of data) {
        array.push([item.value,item.rate])
    }
    var data = google.visualization.arrayToDataTable(array);

    var options = { 'title': item.title, 'width': 550, 'height': 400 };

    var chart = new google.visualization.PieChart(document.getElementById(elementId));
    chart.draw(data, options);
}