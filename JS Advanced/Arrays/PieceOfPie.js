function pieceFoPie(arr, first, second){
    let indexFirst;
    let indexSecond;
    for(let i = 0; i<=arr.length-1; i++){
        if(arr[i]==first){
            indexFirst=i;
        }
        else if(arr[i]==second){
            indexSecond=i;
        }
    }

    let result = arr.slice(indexFirst, indexSecond+1);
    return result;
}

pieceFoPie(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
);