let labels1 = ['La Jolla', 'Chollas Lake', 'Mission Bay'];
let data1 = [69, 31, 50];
let colors1 = ['#49A9EA', '#36CAAB', '#34495E'];

let myChart1 = document.getElementById("myChart").getContext('2d');

let chart1 = new Chart(myChart1, {
    type: 'bar',
    data: {
        labels: labels1,
        datasets: [{
            data: data1,
            backgroundColor: colors1
        }]
    },
    options: {
        title: {
            text: "Do you like doughnuts?",
            display: true
        }
    }

});