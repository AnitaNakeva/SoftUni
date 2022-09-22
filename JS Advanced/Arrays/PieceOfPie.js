function pieceFoPie(arr, first, second){
    let indexFirst = arr.indexOf(first);
    let indexSecond = arr.indexOf(second)+1;
    
    let result = arr.slice(indexFirst, indexSecond);
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