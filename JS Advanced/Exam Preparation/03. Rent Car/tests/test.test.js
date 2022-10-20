let rentCar = require("../rentCar");
let {assert} = require("chai");

describe("test RentCar", function(){
    describe("test searchCar", function(){
        it("test with not an array", function(){
            assert.throw(()=>(rentCar.searchCar(1, "model"), "Invalid input!"));
            assert.throw(()=>(rentCar.searchCar({}, "model"), "Invalid input!"));
            assert.throw(()=>(rentCar.searchCar("1", "model"), "Invalid input!"));
        })
        it("test with not a string", function(){
            assert.throw(()=>(rentCar.searchCar([], 1), "Invalid input!"));
            assert.throw(()=>(rentCar.searchCar([], []), "Invalid input!"));
            assert.throw(()=>(rentCar.searchCar([], {}), "Invalid input!"));
        })
        it("test with no matching elements", function(){
            assert.throw(()=>(rentCar.searchCar(["Audi", "Toyota"], "BMW"), 'There are no such models in the catalog!'))
        })
        it("test with matching elements", function(){
            assert.equal(rentCar.searchCar(["Audi", "Toyota"], "Audi"), `There is 1 car of model Audi in the catalog!`)
            assert.equal(rentCar.searchCar(["Audi", "Toyota", "Audi"], "Audi"), `There is 2 car of model Audi in the catalog!`)
        })
    })

    describe("test calculatePriceOfCar", function(){
        it("test with not an integer", function(){
            assert.throw(()=>(rentCar.checkBudget("", 1.1), "Invalid input!"));
        })
        it("test with not a string", function(){
            assert.throw(()=>(rentCar.calculatePriceOfCar(1, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.calculatePriceOfCar({}, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.calculatePriceOfCar("1", 1), "Invalid input!"));
        })
        it("test with not a number", function(){
            assert.throw(()=>(rentCar.calculatePriceOfCar("", ""), "Invalid input!"));
            assert.throw(()=>(rentCar.calculatePriceOfCar("", []), "Invalid input!"));
            assert.throw(()=>(rentCar.calculatePriceOfCar("", {}), "Invalid input!"));
        })
        it("test with no matching elements", function(){
            assert.throw(()=>(rentCar.calculatePriceOfCar("modelInvalid", 3), 'No such model in the catalog!'))
        })
        it("test with matching elements", function(){
            assert.equal(rentCar.calculatePriceOfCar("Audi", 3), `You choose Audi and it will cost $108!`)
            assert.equal(rentCar.calculatePriceOfCar("Toyota", 5), `You choose Toyota and it will cost $200!`)
        })
    })

    describe("test CheckBudget", function(){
        it("test with not an integer", function(){
            assert.throw(()=>(rentCar.checkBudget(1.1, 1, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget(1, 1.1, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget(1, 1, 1.1), "Invalid input!"));
        })
        it("test with not a number 1st", function(){
            assert.throw(()=>(rentCar.checkBudget("", 1, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget({}, 1, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget([], 1, 1), "Invalid input!"));
        })
        it("test with not a number 2nd", function(){
            assert.throw(()=>(rentCar.checkBudget(1, "1", 1), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget(1, {}, 1), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget(1, [], 1), "Invalid input!"));
        })
        it("test with not a number 3rd", function(){
            assert.throw(()=>(rentCar.checkBudget(1, 1, ""), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget(1, 1, {}), "Invalid input!"));
            assert.throw(()=>(rentCar.checkBudget(1, 1, []), "Invalid input!"));
        })
        it("test with less than budget", function(){
            assert.equal(rentCar.checkBudget(3, 3, 5), 'You need a bigger budget!');
        })
        it("test with more than budget", function(){
            assert.equal(rentCar.checkBudget(3, 3, 10), `You rent a car!`);
        })
        it("test with equal to budget", function(){
            assert.equal(rentCar.checkBudget(3, 3, 9), `You rent a car!`);
        })
    })
})