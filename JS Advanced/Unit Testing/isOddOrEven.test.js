let {assert} = require("chai");
let {isOddOrEven} = require("../02.OddOrEven");

describe("test isOddOrEven functioonality", ()=>{
    describe("test isOddOrEven with incorrect value", ()=>{
        it("Result should be undefined with array argument", ()=>{
            assert.equal(isOddOrEven([]), undefined)
        });

        it("Result should be undefined with empty object argument", ()=>{
            assert.equal(isOddOrEven({}), undefined)
        });

        it("Result should be undefined with number argument", ()=>{
            assert.equal(isOddOrEven(1), undefined)
        });

        it("Result should be undefined with object argument", ()=>{
            assert.equal(isOddOrEven({name: "Name"}), undefined)
        });
    });

    describe("test isOddOrEven with correct value", ()=>{
        it("Result should be even with 'LOVE'", ()=>{
            assert.equal(isOddOrEven("LOVE"), "even");
        });

        it("Result should be odd with 'LOVED'", ()=>{
            assert.equal(isOddOrEven("LOVED"), "odd");
        });
    });
});