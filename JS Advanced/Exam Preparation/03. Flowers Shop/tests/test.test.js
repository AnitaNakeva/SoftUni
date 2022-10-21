let flowerShop = require("../flowerShop");
let {assert} = require('chai');

describe("test flowerShop", function(){
    describe("test calcPriceOfFlowers", function(){
        it("test with not a string", function(){
            assert.throws(()=>(flowerShop.calcPriceOfFlowers([], 1, 1)), "Invalid input!")
            assert.throws(()=>(flowerShop.calcPriceOfFlowers(1, 1, 1)), "Invalid input!")
            assert.throws(()=>(flowerShop.calcPriceOfFlowers({}, 1, 1)), "Invalid input!")
        })
        it("test with not a number 1st", function(){
            assert.throws(()=>(flowerShop.calcPriceOfFlowers("", "", 1)), "Invalid input!")
            assert.throws(()=>(flowerShop.calcPriceOfFlowers("", [], 1)), "Invalid input!")
            assert.throws(()=>(flowerShop.calcPriceOfFlowers("", {}, 1)), "Invalid input!")
        })
        it("test with not a number 2nd", function(){
            assert.throws(()=>(flowerShop.calcPriceOfFlowers("", 1, "")), "Invalid input!")
            assert.throws(()=>(flowerShop.calcPriceOfFlowers("", 1, [])), "Invalid input!")
            assert.throws(()=>(flowerShop.calcPriceOfFlowers("", 1, {})), "Invalid input!")
        })
        it("test with valid data", function(){
            assert.equal(flowerShop.calcPriceOfFlowers("Rose", 2, 3), `You need $6.00 to buy Rose!`)
        })
    })

    describe("test checkFlowersAvailable", function(){
        it("test with missing flower", function(){
            assert.equal(flowerShop.checkFlowersAvailable("Cactus", ["Rose", "Lily", "Orchid"]), `The Cactus are sold! You need to purchase more!`)
        })
        it("test with available flower", function(){
            assert.equal(flowerShop.checkFlowersAvailable("Rose", ["Rose", "Lily", "Orchid"]), `The Rose are available!`)
        })
    })

    describe("test sellFlowers", function(){
        it("test with invalid data", function(){
            assert.throws(()=>(flowerShop.sellFlowers({}, 3), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers("", 3), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers({}, 3), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], -1), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 3), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 4), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], ""), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], []), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], {}), "Invalid input!"));
            assert.throws(()=>(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 1.1), "Invalid input!"));
        })
        it("test with correct data", function(){
            assert.equal(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 2), "Rose / Lily");
            
        })
    })
})