google.charts.load('current', { 'packages': ['corechart'] });

const exampleModal = document.getElementById('exampleModal')
if (exampleModal) {
    exampleModal.addEventListener('show.bs.modal', event => {
        // Button that triggered the modal
        const button = event.relatedTarget
        // Extract info from data-bs-* attributes
        //const recipient = button.getAttribute('data-bs-whatever')
        // If necessary, you could initiate an Ajax request here
        // and then do the updating in a callback.

        // Update the modal's content.
        //const modalTitle = exampleModal.querySelector('.modal-title')
        //const modalBodyInput = exampleModal.querySelector('.modal-body input')

        //modalTitle.textContent = `New message to ${recipient}`
        //modalBodyInput.value = recipient
    })
}

const getData = (pollId) => {
    setTimeout(() => {
        fetch(`https://localhost:44322/vote/getVoteReport/${pollId}`)
            .then(response => response.json())
            .then(data => {
                console.log(data)
                let array = [
                    ['Option', 'NumberOfOption']
                ]
                for (let item of data.voteDetails) {
                    array.push([item.option.value, item.numberOfOption])
                }
                let title = document.getElementById("title")
                title.innerText = data.poll.title

                let description = document.getElementById("description")
                description.innerText = data.poll.description

                let participants = document.getElementById("participants")

                let html = `<table class="table table-hover table-striped table-bordered">`

                for (let participant of data.participants) {
                    html += `<tr>
                                <td>${participant.firstName}</td>
                                <td>${participant.lastName}</td>
                            </tr>`
                }
                html += `</tbody></table>`
                participants.innerHTML = html
                google.charts.setOnLoadCallback(drawChart(array));
            })
            .catch(e => {
                console.log(e);
            })
    }, 200);
}
function drawChart(array) {

    console.log(google.visualization)
    var data = google.visualization.arrayToDataTable([...array]);

    var options = {
        title: "Title",
        width: "700",
        height: "400",
        pieSliceText: 'percentage'
    };

    var chart = new google.visualization.PieChart(document.getElementById('pieChart'));

    chart.draw(data, options);
}