function generateReport() {
    let tableRow = document.querySelectorAll("tbody tr");
    let tableHeader = document.querySelectorAll("thead tr th");
    let result = [];

    for(let i = 0; i<tableRow.length; i++){
        let tableData = tableRow[i].cells;
        let tempData = {};
        for(let j = 0; j<tableData.length; j++){
            let infoTHeader = tableHeader[j].childNodes;
            if(infoTHeader[1].checked){
                tempData[infoTHeader[0].textContent.trim().toLocaleLowerCase()]=tableData[j].textContent;
                
            }
        }
        result.push(tempData);
    }
    let jsonRes = JSON.stringify(result);
    document.getElementById("output").textContent = jsonRes;
}