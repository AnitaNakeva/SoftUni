function validate() {
    document.addEventListener('change', onChange)

    function onChange(event){
    let input = document.getElementById('email').value;
    let isItValid = true;
    if(input===input.toLowerCase()){
        isItValid=true;
    }
    else{
        isItValid=false;
    }
    //console.log(isItValid);

    let pattern = '<name>@<domain>.<extension>';
    let parts = input.split('@');
    let parts2 = input.split('.');
    if(parts.length===2&&parts2.length==2){
        isItValid=true;
    }
    else{
        isItValid=false;
    }
    //console.log(isItValid);

    if(!isItValid){
        document.getElementById('email').classList.add('error');
    }
    
    else{
        document.getElementById('email').classList.remove('error');
    }
}
}