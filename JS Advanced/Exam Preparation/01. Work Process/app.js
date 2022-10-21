function solve() {
    let firstName = document.getElementById("fname");
    let lastName = document.getElementById("lname");
    let email = document.getElementById("email");
    let birth = document.getElementById("birth");
    let position = document.getElementById("position");
    let salary = document.getElementById("salary");
    let hireButton = document.getElementById("add-worker").addEventListener("click", hire);
    let tableBody = document.getElementById("tbody");
    let sumSpan = document.getElementById("sum");
    let salaryForSpan = 0;

    function fire(e){
        let trCurrent = e.target.parentElement.parentElement;
        let currentSalaryToRemove = Number(trCurrent.children[5].textContent);
        salaryForSpan-=currentSalaryToRemove;
        sumSpan.textContent = salaryForSpan.toFixed(2);
        let childrenTB = Array.from(tableBody.children);
        let index;
        for(let i = 0; i<=childrenTB.length-1; i++){
            if(childrenTB[i]===trCurrent){
                index=i;
            }
        }
        tableBody.children[index].remove();
    }

    function edit(e){
        let trCurrent = e.target.parentElement.parentElement;
        let currentSalaryToRemove = Number(trCurrent.children[5].textContent);
        salaryForSpan-=currentSalaryToRemove;
        sumSpan.textContent = salaryForSpan.toFixed(2);

        let childrenTB = Array.from(tableBody.children);
        let index;
        for(let i = 0; i<=childrenTB.length-1; i++){
            if(childrenTB[i]===trCurrent){
                index=i;
            }
        }

        firstName.value = trCurrent.children[0].textContent;
        lastName.value = trCurrent.children[1].textContent;
        email.value = trCurrent.children[2].textContent;
        birth.value = trCurrent.children[3].textContent;
        position.value = trCurrent.children[4].textContent;
        salary.value = trCurrent.children[5].textContent;

        tableBody.children[index].remove();
    }

    function hire(e){
        e.preventDefault();
        if(!firstName.value || !lastName.value || !email.value || !birth.value || !position.value || !salary.value){
            return;
        }

        let tr = document.createElement("tr");
        let tdFN = document.createElement("td");
        tdFN.textContent = firstName.value;
        let tdLN = document.createElement("td");
        tdLN.textContent = lastName.value;
        let tdE = document.createElement("td");
        tdE.textContent = email.value;
        let tdB = document.createElement("td");
        tdB.textContent = birth.value;
        let tdP = document.createElement("td");
        tdP.textContent = position.value;
        let tdS = document.createElement("td");
        tdS.textContent = salary.value;

        let tdButtons = document.createElement("td");
        let buttonFired = document.createElement("button");
        buttonFired.classList.add("fired");
        buttonFired.textContent = "Fired";
        buttonFired.addEventListener("click", fire);
        let buttonEdit = document.createElement("button");
        buttonEdit.classList.add("edit");
        buttonEdit.textContent = "Edit";
        buttonEdit.addEventListener("click", edit);
        tdButtons.appendChild(buttonFired);
        tdButtons.appendChild(buttonEdit);

        tr.appendChild(tdFN);
        tr.appendChild(tdLN);
        tr.appendChild(tdE);
        tr.appendChild(tdB);
        tr.appendChild(tdP);
        tr.appendChild(tdS);
        tr.appendChild(tdButtons);
        tableBody.appendChild(tr);

        let salaryCurrent = Number(salary.value);
        salaryForSpan+=salaryCurrent;
        sumSpan.textContent = salaryForSpan.toFixed(2);

        firstName.value = "";
        lastName.value = "";
        email.value = "";
        birth.value = "";
        position.value = "";
        salary.value = "";
    }
}
solve()