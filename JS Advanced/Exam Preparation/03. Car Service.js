describe("Testing carService", function(){
    describe("test isItExpensive", function(){
        it("test with Engine", function(){
            assert.equal(
                carService.isItExpensive("Engine"),
                "The issue with the car is more severe and it will cost more money"
              );
        });

        it("test with Transmission", function(){
            assert.equal(
                carService.isItExpensive("Transmission"),
                "The issue with the car is more severe and it will cost more money"
              );
        });

        it("test with else", function(){
            assert.equal(
                carService.isItExpensive("Mirror"),
                `The overall price will be a bit cheaper`
              );
        });
    });

    describe("test discount", function(){
        it("test with wrong 1st input", function(){
            assert.throw(()=>(carService.discount("1", 1), "Invalid input"));
            assert.throw(()=>(carService.discount({}, 1), "Invalid input"));
            assert.throw(()=>(carService.discount([], 1), "Invalid input"));
        });

        it("test with wrong 2nd input", function(){
            assert.throw(()=>(carService.discount( 1, "1"), "Invalid input"));
            assert.throw(()=>(carService.discount( 1, []), "Invalid input"));
            assert.throw(()=>(carService.discount( 1, {}), "Invalid input"));
        });

        it("test with numberOfParts smaller than or equalt to 2", function(){
            assert.equal(carService.discount(1, 3), "You cannot apply a discount");
            assert.equal(carService.discount(2, 3), "You cannot apply a discount");
        });

        it("test with numberOfParts between 3 and 7", function(){
            assert.equal(carService.discount(3, 100), `Discount applied! You saved 15$`);
            assert.equal(carService.discount(5, 100), `Discount applied! You saved 15$`);
            assert.equal(carService.discount(7, 100), `Discount applied! You saved 15$`);
        });

        it("test with numberOfParts greater than 7", function(){
            assert.equal(carService.discount(8, 100), `Discount applied! You saved 30$`);
        });
    });

    describe("test partsToBuy", function(){
        it("test with empty partsCatalog", function(){
            assert.equal(carService.partsToBuy([], ["something"]), 0);
        });

        it("test with partsCatalog not an array", function(){
            assert.throws(()=>(carService.partsToBuy(1,[]), "Invalid input"));
            assert.throws(()=>(carService.partsToBuy({},[]), "Invalid input"));
            assert.throws(()=>(carService.partsToBuy("1",[]), "Invalid input"));
        });

        it("test with neededParts not an array", function(){
            assert.throws(()=>(carService.partsToBuy([], 1), "Invalid input"));
            assert.throws(()=>(carService.partsToBuy([], {}), "Invalid input"));
            assert.throws(()=>(carService.partsToBuy([], "1"), "Invalid input"));
        });

        it("test with correct data", function(){
            assert.equal(carService.partsToBuy([{ part: "blowoff valve", price: 145 }, { part: "coil springs", price: 230 }], 
            ["blowoff valve"]), 145);
        });
    });

});