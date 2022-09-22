function diagonalSums(arr){
    let sum1 = 0;
    let sum2 = 0;
    let index1 = 0;
    let index2 = arr[0].length-1;
    
    arr.forEach(row => {
        sum1+=row[index1];
        sum2+=row[index2];
        index1++;
        index2--;
    });

    return(sum1+' '+sum2);
}

diagonalSums([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]
   );