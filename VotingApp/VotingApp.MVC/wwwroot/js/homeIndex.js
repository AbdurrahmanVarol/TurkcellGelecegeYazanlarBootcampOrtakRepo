const exampleModal = document.getElementById('exampleModal')
if (exampleModal) {
    exampleModal.addEventListener('show.bs.modal', event => {
        // Button that triggered the modal
        const button = event.relatedTarget
        // Extract info from data-bs-* attributes
        const recipient = button.getAttribute('data-bs-whatever')
        // If necessary, you could initiate an Ajax request here
        // and then do the updating in a callback.

        // Update the modal's content.
        const modalTitle = exampleModal.querySelector('.modal-title')
        const modalBodyInput = exampleModal.querySelector('.modal-body input')

        modalTitle.textContent = `New message to ${recipient}`
        modalBodyInput.value = recipient
    })
}

const getData = (pollId) => {
    fetch(`https://localhost:44322/getVoteReport/${pollId}`)
        .then(response => response.json())
        .then(data => {
            console.log(data)
            let array = [
                ['Option', 'NumberOfOption']
            ]
            for (let item of data) {
                array.push([item.option.value, item.numberOfOption])
            }
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(drawChart(array));
        })
}
function drawChart(array) {

    var data = google.visualization.arrayToDataTable([...array]);

    var options = {
        title: "Title",
        width: "900",
        height: "400",
        pieSliceText: 'percentage'
    };

    var chart = new google.visualization.PieChart(document.getElementById('pieChart'));

    chart.draw(data, options);
}