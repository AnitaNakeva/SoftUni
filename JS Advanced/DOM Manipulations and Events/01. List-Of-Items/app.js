function addItem() {
    let li = document.createElement('li');
    let ulToAddTo = document.getElementById('items');
    let text = document.getElementById('newItemText').value;
    li.textContent = text;
    ulToAddTo.appendChild(li);
}