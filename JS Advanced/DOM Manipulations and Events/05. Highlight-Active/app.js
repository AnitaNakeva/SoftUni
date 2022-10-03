function focused() {
    let items = document.getElementsByTagName('input');
    for(let item of items){
        item.addEventListener('focus', onFocus);
        item.addEventListener('blur', onBlur);
    }

    function onFocus(event){
        event.target.parentElement.classList.add('focused');
    }

    function onBlur(event){
        event.target.parentElement.classList.remove('focused');
    }
}