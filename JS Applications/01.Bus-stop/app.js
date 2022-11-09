async function getInfo() {
    console.log("TODO...");
    const stopInfoElement = document.getElementById("stopId");
    const stopId = stopInfoElement.value;
    const busList = document.getElementById("buses");
    const stopNameElement = document.getElementById("stopName");

    busList.innerHTML = "";
    
    const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;
    stopInfoElement.value = "";

    try{
    const response = await fetch(url);
    const data = await response.json();

    
    stopNameElement.textContent = data.name;

    Object.entries(data.buses).forEach(([busNumber, timeArrive]) =>{
        const li = document.createElement("li");
        li.textContent = `Bus ${busNumber} arrives in ${timeArrive} minutes`;
    
        busList.appendChild(li);
    });
    } catch(e){
        stopNameElement.textContent = "Error";
    }
}