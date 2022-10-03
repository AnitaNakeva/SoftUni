function change(){
let elements = document.getElementsByTagName('p');

for(let element of elements){
    element.textContent = 'new';
}
}

