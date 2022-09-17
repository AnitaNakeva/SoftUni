function CheckSameNums(num){
    let areTheyTheSame = true;
    let numAsString = num.toString();
    let number = numAsString[0];
    let sum = Number(number);
    for(let i = 1; i<=numAsString.length-1; i++){
        if(numAsString[i]!==number){
            areTheyTheSame=false;
        }
        sum+=Number(numAsString[i]);
    }
    console.log(areTheyTheSame);
    console.log(sum);
}

CheckSameNums(2222);