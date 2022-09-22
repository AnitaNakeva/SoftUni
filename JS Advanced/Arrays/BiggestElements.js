function biggestElements(arr){
    //let max = Number. MIN_VALUE;
    //arr.forEach(row => {
    //    row.forEach(element => {
    //        if(element>max){
    //            max=element
    //        }
    //    });
    //});
    let biggestNum = Number.NEGATIVE_INFINITY;
    arr.forEach(
            row => row.forEach(
                col => biggestNum = Math.max(biggestNum, col)));
    return(biggestNum);
    //return(max);
}

biggestElements([[20, 50, 10],
    [8, 33, 145]]);