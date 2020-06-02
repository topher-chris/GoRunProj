

{
            

            var option = {
                    type: "GET",
                url: "/barchart/data",
                contentType: "application/json;charset=utf-8",
                datatype: "json",
                success: data_arrived
            };
            $.ajax(option);
        }

        function data_arrived(data) {
                    console.log(data);
            var x_data = data[0];
            var y_data = data[1];

            var graph_data = {
                    labels: x_data,
                datasets: [
                    {

                    label: 'Popular Scenery',
                        data: y_data,
                        fill: true,
                        backgroundColor: ['rgba(242,166,54,0.5)', 'rgba(145,65,72,0.5)', 'rgba(74,25,92,0.5)', 'rgba(140,60,55,0.5)', 'rgba(147,0,255,0.5)', 'rgba(0, 0, 255, 0.2)', 'rgba(100, 255, 255, 0.2)'],
                        borderWidth: 2

                    }
                ]
            };
            var panel1 = document.getElementById("myChart").getContext('2d');
            var chart1 = new Chart(
                panel1,
                {
                    type: 'bar',
                    data: graph_data,
                    options: {
                    maintainAspectRatio: false,
                        scales: {
                    yAxes: [{
                    ticks: {
                    beginAtZero: true
                                }
                            }]
                        }
                    },
                    legend: {
                    display: true,
                        position: "right",
                        fullWidth: true,
                        labels: {
                    fontSize: 20,
                            fontColor: '#000'
                        }
                    }
                }
            );
        }  //end of function

   


