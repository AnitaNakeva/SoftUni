function increasingArray(arr){
    let result = [arr[0]];
    let max = arr[0];
    for(let i = 1; i<arr.length; i++){
        if(arr[i]>=max){
            max=arr[i];
            result.push(arr[i]);
        }
    }

    console.log(result);
}

increasingArray([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    );