function solve(arr, type){
    if(type==="asc"){
        arr.sort(function(a, b) {
            return a - b;
          });
    }
    else{
        arr.sort(function(a, b) {
            return b - a;
          });
    }

    console.log(arr);
}

solve([1,5,2], "asc");