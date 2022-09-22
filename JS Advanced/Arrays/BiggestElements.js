function biggestElements(arr){
    let max = Number. MIN_VALUE;
    arr.forEach(row => {
        row.forEach(element => {
            if(element>max){
                max=element
            }
        });
    });

    console.log(max);
}

biggestElements([[20, 50, 10],
    [8, 33, 145]]);