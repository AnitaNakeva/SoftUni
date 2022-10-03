function addItem() {
    let li = document.createElement('li');
    let text = document.getElementById('newItemText').value;
    li.textContent = text;
    document.getElementById('items').appendChild(li);

    let buttonDel = document.createElement('a');
   // let href = document.createElement('href');
   // href.textContent = '#';
   // li.addItem(href);
    buttonDel.textContent = '[Delete]';
    buttonDel.addEventListener('click', onClick);
    function onClick(event){
        event.target.parentElement.remove();
    }

    li.appendChild(buttonDel);
}
