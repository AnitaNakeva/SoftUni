let {assert} = require('chai');
let {lookupChar} = require("../03.CharLookup");

describe("test charLookup functionality", ()=>{
    describe("test charLookup with incorrect value", ()=>{
        it("Result should be undefined with array parameter", ()=>{
            assert.equal(lookupChar([], 1), undefined);
        });

        it("Result should be undefined with object parameter", ()=>{
            assert.equal(lookupChar({}, 1), undefined);
        });

        it("Result should be undefined with number parameter", ()=>{
            assert.equal(lookupChar(2, 1), undefined);
        });

        it("Result should be undefined with array index", ()=>{
            assert.equal(lookupChar("string", []), undefined);
        });

        it("Result should be undefined with object index", ()=>{
            assert.equal(lookupChar("string", {}), undefined);
        });

        it("Result should be undefined with decimal index", ()=>{
            assert.equal(lookupChar("string", 1.1), undefined);
        });

        it("Result should be undefined with string index", ()=>{
            assert.equal(lookupChar("string", "string"), undefined);
        });
    });

    describe("test charLookup with correct value but with incorrect index", ()=>{
        it("Result should be 'Incorrect index' with negative index", ()=>{
            assert.equal(lookupChar("string", -1), "Incorrect index");
        });

        it("Result should be 'Incorrect index' with index bigger than the string length", ()=>{
            assert.equal(lookupChar("string", 7), "Incorrect index");
        });

        it("Result should be 'Incorrect index' with index equal to the string length", ()=>{
            assert.equal(lookupChar("string", 6), "Incorrect index");
        });
    })

    describe("test charLookup with correct value", ()=>{
        it("Result should be s at index 1", ()=>{
            assert.equal(lookupChar("string", 0), "s");
        });
    });
});