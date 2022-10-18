window.addEventListener("load", solve);

function solve() {
  let make = document.getElementById("make");
  let model = document.getElementById("model");
  let productionYear = document.getElementById("year");
  let fuelType = document.getElementById("fuel");
  let originalCost = document.getElementById("original-cost");
  let sellingPrice = document.getElementById("selling-price");
  let publishButton = document.getElementById("publish").addEventListener("click", publish);
  let tableBody = document.getElementById("table-body");
  let carList = document.getElementById("cars-list");
  let profit = document.getElementById("profit");

  function edit(e){
    let trParent = e.target.parentElement.parentElement;
    make.value = trParent.children[0].innerText;
    model.value = trParent.children[1].innerText;
    productionYear.value = trParent.children[2].innerText;
    fuelType.value = trParent.children[3].innerText;
    originalCost.value = trParent.children[4].innerText;
    sellingPrice.value = trParent.children[5].innerText;

    tableBody.getElementsByTagName("tr")[0].remove();
  }

  function sell(e){
    let trParent = e.target.parentElement.parentElement;
    tableBody.getElementsByTagName("tr")[0].remove();
    //carList.appendChild(trParent);
    //Array.from(trParent.children[6].getElementsByTagName("button")).forEach(x=>x.remove());
    let li = document.createElement("li");
    li.classList.add("each-list");
    let span1 = document.createElement("span");
    span1.textContent = trParent.children[0].innerText + " " + trParent.children[1].innerText;
    let span2 = document.createElement("span");
    span2.textContent = trParent.children[2].innerText;
    let span3 = document.createElement("span");
    let difference = Number(trParent.children[5].innerText) - Number(trParent.children[4].innerText);
    span3.textContent = difference;

    li.appendChild(span1);
    li.appendChild(span2);
    li.appendChild(span3);

    carList.appendChild(li);

    profit.textContent = Number(Number(profit.textContent)+difference).toFixed(2);
  }

  function publish(e){
    e.preventDefault();
    if(!make.value || !model.value || originalCost.value>sellingPrice.value || !originalCost.value || !sellingPrice.value || !productionYear.value || !fuelType.value){
      return;
    }
    let tr = document.createElement("tr");
    tr.classList.add("row");
    let tdMake = document.createElement("td");
    tdMake.textContent = make.value;
    tr.appendChild(tdMake);
    let tdModel = document.createElement("td");
    tdModel.textContent = model.value;
    tr.appendChild(tdModel);
    let tdYear = document.createElement("td");
    tdYear.textContent = productionYear.value;
    tr.appendChild(tdYear);
    let tdFuel = document.createElement("td");
    tdFuel.textContent = fuelType.value;
    tr.appendChild(tdFuel);
    let tdOriginal = document.createElement("td");
    tdOriginal.textContent = originalCost.value;
    tr.appendChild(tdOriginal);
    let tdSelling = document.createElement("td");
    tdSelling.textContent = sellingPrice.value;
    tr.appendChild(tdSelling);

    let buttonTd = document.createElement("td");

    let buttonEdit = document.createElement("button");
    buttonEdit.classList.add("action-btn", "edit");
    buttonEdit.textContent = "Edit";
    buttonEdit.addEventListener("click", edit);

    let buttonSell = document.createElement("button");
    buttonSell.classList.add("action-btn", "sell");
    buttonSell.textContent = "Sell";
    buttonSell.addEventListener("click", sell);

    buttonTd.appendChild(buttonEdit);
    buttonTd.appendChild(buttonSell);
    tr.appendChild(buttonTd);
    
    tableBody.appendChild(tr);

    make.value = "";
    model.value = "";
    productionYear.value = "";
    fuelType.value = "";
    originalCost.value = "";
    sellingPrice.value = "";

  }
}
