function addItem() {
    let newText = document.getElementById("newItemText").value;
    let newValue = document.getElementById("newItemValue").value;
    let op = document.createElement('option');
    op.textContent = newText;
    op.value = newValue;
    document.getElementById("menu").appendChild(op);
    document.getElementById("newItemText").value = "";
    document.getElementById("newItemValue").value = "";
}