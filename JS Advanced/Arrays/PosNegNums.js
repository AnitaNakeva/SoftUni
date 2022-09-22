function posNegNums(arr){
    let newArr = [];
    arr.forEach(element => {
        if(element<0){
            newArr.unshift(element);
        }
        else{
            newArr.push(element);
        }
    });

    newArr.forEach(element => {
        console.log(element);
    });
}

posNegNums([7, -2, 8, 9]);