function cookingByNumbers(num, com1, com2, com3, com4, com5){
    let number = Number(num);
    let commandss = [com1, com2, com3, com4, com5];

    commandss.forEach(element => {
        switch(element){
            case 'chop': number=number/2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number+=1; break;
            case 'bake': number*=3; break;
            case 'fillet': number-=number*20/100; break;
        }

        console.log(number);
    });
}

cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');