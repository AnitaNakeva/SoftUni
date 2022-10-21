function solve() {
    let name = document.getElementById("recipientName");
    let title = document.getElementById("title");
    let message = document.getElementById("message");
    let buttonSubmit = document.getElementById("add").addEventListener("click", add);
    let buttonReset = document.getElementById("reset").addEventListener("click", reset);
    let divlistMails = document.getElementsByClassName("list-mails")[0];
    let ulInDiv = divlistMails.getElementsByTagName("ul")[0];
    let ulSent = document.getElementsByClassName("sent-list")[0];
    let ulDeleted = document.getElementsByClassName("delete-list")[0];

    function deleteItem(e){
        parentLi = e.target.parentElement.parentElement;
        
        //ulDeleted.appendChild(parentLi);
        let li = document.createElement("li");
        let spanTo = document.createElement("span");
        spanTo.textContent = "To: " + parentLi.children[1].textContent.split(": ")[1];
        let spanTitle = document.createElement("span");
        spanTitle.textContent = parentLi.children[0].textContent;
        
        li.appendChild(spanTo);
        li.appendChild(spanTitle);
        ulDeleted.appendChild(li);
        //parentLi.children[0].remove();
        //parentLi.children[0].remove();
        //parentLi.children[0].remove();
        //parentLi.children[0].remove();
        e.target.parentElement.parentElement.remove();
        //ulDeleted.children[0].remove();


    }

    function send(e){
        let liParent = e.target.parentElement.parentElement;
        ulInDiv.getElementsByTagName("li")[0].remove();
        let li = document.createElement("li");
        let spanName = document.createElement("span");
        let nameFromLi = liParent.children[1].textContent.split(": ")[1];
        spanName.textContent = "To: " + nameFromLi;

        let titleFromLi = liParent.children[0].textContent.split(": ")[1];
        let spanTitle = document.createElement("span");
        spanTitle.textContent = "Title: " +titleFromLi;

        li.appendChild(spanName);
        li.appendChild(spanTitle);

        let div = document.createElement("div");
        div.classList.add("btn");
        let buttonDel = document.createElement("button");
        buttonDel.type = "submit";
        buttonDel.classList.add("delete");
        buttonDel.textContent = "Delete";
        buttonDel.addEventListener("click", deleteItem);


        div.appendChild(buttonDel);
        li.appendChild(div);

        ulSent.appendChild(li);
    }

    function reset(e){
        e.preventDefault();

        name.value = "";
        title.value = "";
        message.value = "";
    }

    function add(e){
        e.preventDefault();
        if(!name.value || !title.value || !message.value){
            return;
        }

        let li = document.createElement("li");
        let h4 = document.createElement("h4");
        h4.textContent = "Title: " + title.value;
        let h4name = document.createElement("h4");
        h4name.textContent = "Recipient Name: " + name.value;
        let span = document.createElement("span");
        span.textContent = message.value;

        let div = document.createElement("div");
        div.id = "List-action";

        let buttonSend = document.createElement("button");
        buttonSend.type = "submit";
        buttonSend.id = "send";
        buttonSend.textContent = "Send";
        buttonSend.addEventListener("click", send);

        let buttonDelete = document.createElement("button");
        buttonDelete.type = "submit";
        buttonDelete.id = "delete";
        buttonDelete.textContent = "Delete";
        buttonDelete.addEventListener("click", deleteItem);

        div.appendChild(buttonSend);
        div.appendChild(buttonDelete);

        li.appendChild(h4);
        li.appendChild(h4name);
        li.appendChild(span);
        li.appendChild(div);

        ulInDiv.appendChild(li);

        name.value = "";
        title.value = "";
        message.value = "";
    
    
    }

}
solve()