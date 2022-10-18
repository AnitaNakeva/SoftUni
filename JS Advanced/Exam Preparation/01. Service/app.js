
window.addEventListener("load", solve);


function solve(){
    let productType = document.getElementById("type-product");
    //var productTypeText = productType.options[productType.selectedIndex].text;
    //let pt = productType.value;
    let description = document.getElementById("description");
    let clientName = document.getElementById("client-name");
    let clientPhone = document.getElementById("client-phone");
    let submitButton = document.querySelector("button[type='submit']").addEventListener("click", submitData);
    let sectionReceived = document.getElementById("received-orders");
    let sectionCompleted = document.getElementById("completed-orders");
    let buttonClear = sectionCompleted.getElementsByTagName("button")[0].addEventListener("click", clear);

    function clear(e){
        Array.from(sectionCompleted.querySelectorAll(".container")).forEach(x=>x.remove());
    }

    function startRepair(e){

        e.target.disabled = true;
        let parEl = e.target.parentElement;
        let button2 = parEl.getElementsByTagName("button")[1];
        button2.disabled = false;
    }

    function finishRepair(e){
        let divToMove = sectionReceived.getElementsByTagName("div")[0];
        //sectionReceived.getElementsByTagName("div")[0].remove();
        sectionCompleted.appendChild(divToMove);
        Array.from(divToMove.getElementsByTagName("button")).forEach(x=>x.remove());
        //divToMove.getElementsByTagName("button")[1].remove();
        //divToMove.getElementsByTagName("button")[0].remove();
    }

    function submitData(e){
        e.preventDefault();
        if(!clientName.value){
            return;
        }
        if(!clientPhone.value){
            return;
        }
        if(!description.value){
            return;
        }
        let div = document.createElement("div");
        div.classList.add("container");
        let h2 = document.createElement("h2");
        h2.textContent = "Product type for repair: " + productType.value;
        let h3 = document.createElement("h3");
        h3.textContent = "Client information: " + clientName.value + ", " + clientPhone.value;
        let h4 = document.createElement("h4");
        h4.textContent = "Description of the problem: " + description.value;
        div.appendChild(h2);
        div.appendChild(h3);
        div.appendChild(h4);
        let buttonStart = document.createElement("button");
        buttonStart.classList.add("start-btn");
        buttonStart.textContent = "Start repair";
        buttonStart.addEventListener("click", startRepair);
        let buttonFinish = document.createElement("button");
        buttonFinish.classList.add("finish-btn");
        buttonFinish.disabled = true;
        buttonFinish.textContent = "Finish repair";
        buttonFinish.addEventListener("click", finishRepair);
        description.value = "";
        clientPhone.value = "";
        clientName.value = "";
        productType.value = "Computer";
        div.appendChild(buttonStart);
        div.appendChild(buttonFinish);
        sectionReceived.appendChild(div);
    }
}