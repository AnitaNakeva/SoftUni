function echo(input1, input2, input3){
    let length1 = input1.length;
    let length2 = input2.length;
    let length3 = input3.length;
    let endLength = length1+length2+length3;
    let averageLength = Math.floor(endLength/3);
    console.log(endLength);
    console.log(averageLength);
}