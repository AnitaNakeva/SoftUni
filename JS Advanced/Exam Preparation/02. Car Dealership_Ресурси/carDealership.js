class CarDealership {
    constructor(name){
        this.name = name;
        this.availableCars = [];
        this.soldCars = [];
        this.totalIncome = 0;
    }

    addCar(model, horsepower, price, mileage){
        if(!Number.isInteger(horsepower)){
            throw new Error("Invalid input!");
        }
        if(model==="" || horsepower <0 || price <0 || mileage <0){
            throw new Error("Invalid input!");
        }
        let car = {
            model, horsepower, price, mileage
        };
        this.availableCars.push(car);
        return `New car added: ${model} - ${horsepower} HP - ${mileage.toFixed(2)} km - ${price.toFixed(2)}$`;
    }

    sellCar(model, desiredMileage){
        let car = this.availableCars.find(x=>x.model===model);
        if(!car){
            throw new Error(`${model} was not found!`);
        }
        let price = 0;
        let difference = car.mileage - desiredMileage;
        if(difference<=0){
            price = car.price;
        }
        else if(difference<=40000){
            price = car.price - car.price*5/100;
        }
        else{
            price = car.price - car.price*10/100;
        }

        this.availableCars = this.availableCars.filter(x=>x.model!==model);
        let soldCar = {
            model: car.model,
            horsepower: car.horsepower,
            soldPrice: price
        };
        this.soldCars.push(soldCar);
        this.totalIncome+=price;
        return `${model} was sold for ${price.toFixed(2)}$`;
    }

    currentCar(){
        let buff = "-Available cars:\n";
        if(this.availableCars.length>0){
            for(let i = 0; i<this.availableCars.length-1; i++){
                buff+=`---${this.availableCars[i].model} - ${this.availableCars[i].horsepower} HP - ${this.availableCars[i].mileage.toFixed(2)} km - ${this.availableCars[i].price.toFixed(2)}$\n`;
            }
            buff+=`---${this.availableCars[this.availableCars.length-1].model} - ${this.availableCars[this.availableCars.length-1].horsepower} HP - ${this.availableCars[this.availableCars.length-1].mileage.toFixed(2)} km - ${this.availableCars[this.availableCars.length-1].price.toFixed(2)}$`;
        }
        else{
            buff="There are no available cars";
        }

        return buff;
    }

    salesReport(criteria){
        let sortedSoldCars;
        if(criteria!=="horsepower" && criteria!=="model"){
            throw new Error("Invalid criteria!");
        }
        else if(criteria==="horsepower"){
            sortedSoldCars = this.soldCars.sort((a,b)=>b.horsepower-a.horsepower);
        }
        else if(criteria === "model"){
            //sortedSoldCars = this.soldCars.sort((a,b)=>a.model-b.model);
            sortedSoldCars = this.soldCars.sort((a, b) =>
    a.model.localeCompare(b.model));
        }

        let buff = `-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$\n`;
        buff+=`-${this.soldCars.length} cars sold:\n`;
        for(let i = 0; i<sortedSoldCars.length-1; i++){
            buff+=`---${sortedSoldCars[i].model} - ${sortedSoldCars[i].horsepower} HP - ${sortedSoldCars[i].soldPrice.toFixed(2)}$\n`;
        }
        if(sortedSoldCars.length>0){
            buff+=`---${sortedSoldCars[sortedSoldCars.length-1].model} - ${sortedSoldCars[sortedSoldCars.length-1].horsepower} HP - ${sortedSoldCars[sortedSoldCars.length-1].soldPrice.toFixed(2)}$`
        }
        return buff;
    }

}
let dealership = new CarDealership('SoftAuto');
dealership.addCar('Toyota Corolla', 100, 3500, 190000);
dealership.addCar('Mercedes C63', 300, 29000, 187000);
dealership.addCar('Audi A3', 120, 4900, 240000);
dealership.sellCar('Toyota Corolla', 230000);
dealership.sellCar('Mercedes C63', 110000);
console.log(dealership.salesReport('model'));

