let bookSelection = require("../bookSelection");
let {assert} = require("chai");

describe("test bookSelection", function(){
    describe("test IsGenreSuitable", function(){
        it("test with Thriller and less than 13", function(){
            assert.equal(bookSelection.isGenreSuitable("Thriller", 12), `Books with Thriller genre are not suitable for kids at 12 age`)
        })

        it("test with Thriller and less than 13", function(){
            assert.equal(bookSelection.isGenreSuitable("Thriller", 11), `Books with Thriller genre are not suitable for kids at 11 age`)
        })

        it("test with Horror and less than 13", function(){
            assert.equal(bookSelection.isGenreSuitable("Horror", 12), `Books with Horror genre are not suitable for kids at 12 age`)
        })

        it("test with Horror and less than 13", function(){
            assert.equal(bookSelection.isGenreSuitable("Horror", 11), `Books with Horror genre are not suitable for kids at 11 age`)
        })

        it("test with Horror and more than 12", function(){
            assert.equal(bookSelection.isGenreSuitable("Horror", 13), `Those books are suitable`)
        })

        it("test with Thriller and more than 12", function(){
            assert.equal(bookSelection.isGenreSuitable("Thriller", 13), `Those books are suitable`)
        })

        it("test with Horror and more than 12", function(){
            assert.equal(bookSelection.isGenreSuitable("Horror", 15), `Those books are suitable`)
        })

        it("test with Thriller and more than 12", function(){
            assert.equal(bookSelection.isGenreSuitable("Thriller", 15), `Those books are suitable`)
        })

        it("test with other genre", function(){
            assert.equal(bookSelection.isGenreSuitable("Romance", 13), `Those books are suitable`)
        })

        it("test with other genre", function(){
            assert.equal(bookSelection.isGenreSuitable("Romance", 11), `Those books are suitable`)
        })

        it("test with other genre", function(){
            assert.equal(bookSelection.isGenreSuitable("Romance", 12), `Those books are suitable`)
        })
    })

    describe("test isItAffrodable", function(){
        it("test with 1st NAN", function(){
            assert.throw(()=>(bookSelection.isItAffordable("1",3), "Invalid input"))
        })

        it("test with 1st NAN", function(){
            assert.throw(()=>(bookSelection.isItAffordable({},3), "Invalid input"))
        })

        it("test with 1st NAN", function(){
            assert.throw(()=>(bookSelection.isItAffordable([],3), "Invalid input"))
        })

        it("test with 2nd NAN", function(){
            assert.throw(()=>(bookSelection.isItAffordable(1,"3"), "Invalid input"))
        })

        it("test with 2nd NAN", function(){
            assert.throw(()=>(bookSelection.isItAffordable(1,{}), "Invalid input"))
        })

        it("test with 2nd NAN", function(){
            assert.throw(()=>(bookSelection.isItAffordable(1,[]), "Invalid input"))
        })

        it("test with less than the budget", function(){
            assert.equal(bookSelection.isItAffordable(1,3), `Book bought. You have 2$ left`);
        })

        it("test with equal to the budget", function(){
            assert.equal(bookSelection.isItAffordable(3,3), `Book bought. You have 0$ left`);
        })

        it("test with more than the budget", function(){
            assert.equal(bookSelection.isItAffordable(5,3), "You don't have enough money");
        })
    })

    describe("test suitableTitles", function(){
        it("test with not an array", function(){
            assert.throw(()=>(bookSelection.suitableTitles(1, "str"), "Invalid input"))
        })

        it("test with not an array", function(){
            assert.throw(()=>(bookSelection.suitableTitles({}, "str"), "Invalid input"))
        })

        it("test with not an array", function(){
            assert.throw(()=>(bookSelection.suitableTitles("1", "str"), "Invalid input"))
        })

        it("test with not a string", function(){
            assert.throw(()=>(bookSelection.suitableTitles([], 1), "Invalid input"))
        })

        it("test with not a string", function(){
            assert.throw(()=>(bookSelection.suitableTitles([], []), "Invalid input"))
        })

        it("test with not a string", function(){
            assert.throw(()=>(bookSelection.suitableTitles([], {}), "Invalid input"))
        })

        it("test with no books matching", function(){
            let result = bookSelection.suitableTitles([{ title: "The Da Vinci Code", genre: "Thriller" }, {title: "Sometitle", genre: "Horror"}], "Romance");
            assert.equal(result.length, 0);
        })

        it("test with some books matching", function(){
            let result = bookSelection.suitableTitles([{ title: "The Da Vinci Code", genre: "Thriller" }, {title: "Sometitle", genre: "Horror"}], "Thriller");
            assert.equal(result.length, 1);
        })
    })
})