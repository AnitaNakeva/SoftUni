function solve() {
    let infoBox = document.getElementById("info");
    let currentName = "Depot";
    let currentId = "depot";
    let url = `http://localhost:3030/jsonstore/bus/schedule/`;
    async function depart() {
        let currentURL = url+currentId;
        try{
        let response = await fetch(currentURL);
        let data = await response.json();
        let name = data.name;
        let next = data.next;
        
        document.getElementById("depart").disabled = true;
        document.getElementById("arrive").disabled = false;
        
        infoBox.textContent = "Next stop "+name;
        
        currentName = name;
        }
        catch{
            infoBox.textContent = "Error";
            document.getElementById("depart").disabled = true;
            document.getElementById("arrive").disabled = true;
        }
    }

    async function arrive() {
        document.getElementById("depart").disabled = false;
        document.getElementById("arrive").disabled = true;
        let currentURL = url+currentId;
        try{
        let response = await fetch(currentURL);
        let data = await response.json();
        let name = data.name;
        let next = data.next;
        currentId = next;
        infoBox.textContent = "Arriving at "+name;
        }
    catch{
        infoBox.textContent = "Error";
        document.getElementById("depart").disabled = true;
        document.getElementById("arrive").disabled = true;
    }
    }


    return {
        depart,
        arrive
    };
}

let result = solve();