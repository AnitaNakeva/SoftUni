function solution(){
    let products = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    let recipes = {
        apple: {carbohydrate: 1, flavour: 2},
        lemonade: {carbohydrate: 10, flavour: 20},
        burger: {carbohydrate: 5, fat: 7, flavour: 3},
        eggs: {protein: 5, fat: 1, flavour:1},
        turkey: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
    }

    return function cook(input){
        let command = input.split(" ");
        if(command[0]==="restock"){
            let microel = command[1];
            let quantity = Number(command[2]);
            products[microel]+=quantity;
            return "Success";
        }
        else if(command[0]==="prepare"){
            let recipe = command[1];
            let quantity = Number(command[2]);
            let pr = products["protein"];
            let car = products["carbohydrate"];
            let f = products["fat"];
            let fl = products["flavour"];

            for(let i = 1; i<=quantity; i++){
                let obj = recipes[recipe];
                for(let ing in obj){
                    products[ing]-=obj[ing];
                    if(products[ing]<0){
                        products["protein"] = pr;
                        products["carbohydrate"] = car;
                        products["fat"] = f;
                        products["flavour"] = fl;
                        return "Error: not enough "+ing+" in stock";
                    }
                    else{

                    }
                }
                
            }
            return "Success";
        }
        else if(command[0]==="report"){
            let report = "";
            for(let pr in products){
                report+=pr+"="+products[pr]+" ";
            }
            return report.trimEnd();
        }
    }
}



let manager = solution ();

console.log(manager("prepare turkey 1"));
console.log(manager("restock protein 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock carbohydrate 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock flavour 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("report"));
/*
prepare turkey 1

restock protein 10

prepare turkey 1

restock carbohydrate 10

prepare turkey 1

restock fat 10

prepare turkey 1

restock flavour 10

prepare turkey 1

report
*/
//console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in

//console.log (manager ("restock carbohydrate 10"));
//console.log (manager ("restock flavour 10"));
//console.log (manager ("prepare apple 1"));

