function lockedProfile() {
    let buttons = document.getElementsByTagName('button');
    for(let button of buttons){
        button.addEventListener("click", onClick)
    }

    function onClick(e){
        let button = e.target;
        let div = button.parentElement;
        let hiddenText = div.getElementsByTagName('div')[0];
        let radioButtons = div.querySelector('input[type="radio"]:checked').value;
        if(radioButtons==='unlock'){
            if(button.textContent==="Show more"){
            hiddenText.style.display = 'block';
            button.textContent = 'Hide it';
            }
            else{
                hiddenText.style.display = 'none';
                button.textContent = 'Show more';
            }
        }
        
    }
}
  