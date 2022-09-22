function sortingNumbers(arr){
    arr.sort((a,b)=>a-b);
    let num = 0;
    let result = [];
    for(let i = 0; i<arr.length; i+=2){
        result[i]=arr[num];
        num++;
    }
    arr.sort((a,b)=>b-a);
    num=0;
    for(let i = 1; i<=arr.length; i+=2){
        result[i]=arr[num];
        num++;
    }

    return(result);
}

sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);