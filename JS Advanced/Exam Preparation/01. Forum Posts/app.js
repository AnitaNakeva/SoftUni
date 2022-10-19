window.addEventListener("load", solve);

function solve() {
  let title = document.getElementById("post-title");
  let category = document.getElementById("post-category");
  let content = document.getElementById("post-content");
  let publishButton = document.getElementById("publish-btn").addEventListener("click", publish);
  let reviewList = document.getElementById("review-list");
  let publishedList = document.getElementById("published-list");
  let buttonClear = document.getElementById("clear-btn").addEventListener("click", clear);

  function clear(e){
    Array.from(publishedList.children).forEach(x=>x.remove());
  }

  function edit(e){
    let liParent = e.target.parentElement;
    let elements = liParent.children[0];
    let h4El = elements.getElementsByTagName("h4")[0].textContent;
    title.value = h4El;
    let p1El = elements.getElementsByTagName("p")[0].textContent.split(": ")[1];
    category.value = p1El;
    let p2El = elements.getElementsByTagName("p")[1].textContent.split(": ")[1];
    content.value = p2El;

    reviewList.children[0].remove();
  }

  function approve(e){
    let liParent = e.target.parentElement;
    publishedList.appendChild(liParent);
    liParent.children[1].remove();
    liParent.children[1].remove();
  }

  function publish(e){
    if(!title.value || !category.value || !content.value){
      return;
    }

    let li = document.createElement("li");
    li.classList.add("rpost");
    let article = document.createElement("article");
    let h4 = document.createElement("h4");
    h4.textContent = title.value;
    let p1 = document.createElement("p");
    p1.textContent = "Category: " + category.value;
    let p2 = document.createElement("p");
    p2.textContent = "Content: " + content.value;

    article.appendChild(h4);
    article.appendChild(p1);
    article.appendChild(p2);
    li.appendChild(article);
    reviewList.appendChild(li);

    title.value = "";
    category.value = "";
    content.value = "";

    let buttonEdit = document.createElement("button");
    buttonEdit.classList.add("action-btn", "edit");
    buttonEdit.textContent = "Edit";
    buttonEdit.addEventListener("click", edit);

    let buttonApprove = document.createElement("button");
    buttonApprove.classList.add("action-btn", "approve");
    buttonApprove.textContent = "Approve";
    buttonApprove.addEventListener("click", approve);

    li.appendChild(buttonEdit);
    li.appendChild(buttonApprove);
  }
}
