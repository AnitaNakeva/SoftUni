function nthElement(arr, step){
    let result = [];
    for(let i = 0; i<arr.length; i+=step){
        result.push(arr[i]);
    }
    
    console.log(result.join(', '));
    return result;
}

nthElement(['dsa',
'asd', 
'test', 
'tset'], 
2

);