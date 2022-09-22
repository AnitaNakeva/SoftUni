function rotateArray(arr, times){
    for(let i = 0; i<times; i++){
        let last = arr.pop();
        arr.unshift(last);
    }

    console.log(arr.join());
}

rotateArray(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
);