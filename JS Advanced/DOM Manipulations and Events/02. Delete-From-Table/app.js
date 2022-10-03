function deleteByEmail() {
    let input = document.getElementsByName('email')[0].value;
    let dataCols = document.querySelectorAll('#customers td:nth-child(2)');
    let isItAMatch = false;
    for(let col of dataCols){
        if(col.textContent===input){
            isItAMatch=true;
            col.parentElement.remove();
        }
    }

    if(isItAMatch){
        document.getElementById('result').textContent='Deleted.';

    }
    else{
        document.getElementById('result').textContent='Not found.';
    }
}