const CHART=document.getElementById("lineChart");
console.log(CHART);

Chart.defaults.global.animation.onComplete=()=> {
	console.log('finished');
}
let lineChart = new Chart(CHART, {
	type:'bar',
	data: {
		labels: ["January", "February", "March", "April", "May", "June", "July", "August"],
		datasets: [
		{
		label: "Produced 2014",
		fill: false,
		lineTension:0.1,
		backgroundColor: "rgba(230,236,240,0.4)",
		borderCapStyle: 'butt',
		boderDash: [],
		borderDashOffset: 0.0,
		borderJointStyle: 'miter',
		pointerBorderColor: "rgba(0,158,227,1)",
		pointBackgroundColor: "#fff",
		pointBorderWidth: 1,
		pointHoverRadius: 5,
		pointHoverBackgroundColor: "rgba(0,124,170,1)",
		pointHoverBorderColor: "rgba(0,158,227,1)",
		pointHoverBorderWidth: 2,
		pointRadius: 1,
		data: [65,59,80,81,56,55,40,60],
		},

		{
		label: "Produced 2015",
		fill: true,
		lineTension:0,
		backgroundColor: "rgba(230,236,240,0.4)",
		borderCapStyle: 'butt',
		boderDash: [],
		borderDashOffset: 0.0,
		borderJointStyle: 'miter',
		pointerBorderColor: "rgba(0,158,227,1)",
		pointBackgroundColor: "#fff",
		pointBorderWidth: 1,
		pointHoverRadius: 5,
		pointHoverBackgroundColor: "rgba(0,124,170,1)",
		pointHoverBorderColor: "rgba(0,158,227,1)",
		pointHoverBorderWidth: 2,
		pointRadius: 1,
		data: [100,9,84,51,66,75,45,70],
		},
		
		{
		label: "Produced 2016",
		fill: true,
		lineTension:0,
		backgroundColor: "rgba(230,236,240,0.4)",
		borderCapStyle: 'butt',
		boderDash: [],
		borderDashOffset: 0.0,
		borderJointStyle: 'miter',
		pointerBorderColor: "rgba(0,158,227,1)",
		pointBackgroundColor: "#fff",
		pointBorderWidth: 1,
		pointHoverRadius: 5,
		pointHoverBackgroundColor: "rgba(0,124,170,1)",
		pointHoverBorderColor: "rgba(0,158,227,1)",
		pointHoverBorderWidth: 2,
		pointRadius: 1,
		data: [120,109,104,91,100,95,70,75],
		},

		{
		label: "Produced 2017",
		fill: true,
		lineTension:0,
		backgroundColor: "rgba(230,236,240,0.4)",
		borderCapStyle: 'butt',
		boderDash: [],
		borderDashOffset: 0.0,
		borderJointStyle: 'miter',
		pointerBorderColor: "rgba(229,0,125,1)",
		pointBackgroundColor: "#fff",
		pointBorderWidth: 1,
		pointHoverRadius: 5,
		pointHoverBackgroundColor: "rgba(168,0,92,1)",
		pointHoverBorderColor: "rgba(229,0,125,1)",
		pointHoverBorderWidth: 2,
		pointRadius: 1,
		data: [130,119,124,111,106,105,100,90],
		}
		]
	},
	options: {
		scales:{
			yAxes: [{
				ticks: {
					reverse: false,
					beginAtZero: true
				}
			}]
		}
	}
});
