let companyAdministration = require('../companyAdministration');
let {assert} = require('chai');

describe("companyAdminostration tests", function(){
    describe("test hiringEmployee", function(){
        it("test different position", function(){
            let message = `We are not looking for workers for this position.`;
            assert.throw(()=>companyAdministration.hiringEmployee("Peter", "IT", 33), message);
        })

        it("test less than 3 years of experience", function(){
            let message = `Ivan is not approved for this position.`;
            assert.equal(companyAdministration.hiringEmployee("Ivan", "Programmer", 2), message);
        })

        it("test with greater than 3", function(){
            let message = `Pavel was successfully hired for the position Programmer.`;
            assert.equal(companyAdministration.hiringEmployee("Pavel", "Programmer", 5), message);
        })

        it("test with equal to 3", function(){
            let message = `Pavel was successfully hired for the position Programmer.`;
            assert.equal(companyAdministration.hiringEmployee("Pavel", "Programmer", 3), message);
        })
    })

    describe("test calculateSalary", function(){
        it("test with a negative number", function(){
            let message = "Invalid hours";
            assert.throw(()=>(companyAdministration.calculateSalary(-3), message));
        })

        it("test with a string", function(){
            let message = "Invalid hours";
            assert.throw(()=>(companyAdministration.calculateSalary("3"), message));
        })

        it("test with an array", function(){
            let message = "Invalid hours";
            assert.throw(()=>(companyAdministration.calculateSalary([]), message));
        })

        it("test with an object", function(){
            let message = "Invalid hours";
            assert.throw(()=>(companyAdministration.calculateSalary({}), message));
        })

        it("test with correct data and less than 160 hours", function(){
            let message = 30;
            assert.equal(companyAdministration.calculateSalary(2), message);
        })

        it("test with correct data and more than 160 hours", function(){
            let message = 3415;
            assert.equal(companyAdministration.calculateSalary(161), message);
        })
    })

    describe("test firedEmployee" , function(){
        it("test with 1 parameter not an array", function(){
            let message = "Invalid input";
            assert.throw(()=>(companyAdministration.firedEmployee("emp", 1), message));
            assert.throw(()=>(companyAdministration.firedEmployee(2, 1), message));
            assert.throw(()=>(companyAdministration.firedEmployee({}, 1), message));
        })

        it("test with 2 parameter not a number", function(){
            let message = "Invalid input";
            assert.throw(()=>(companyAdministration.firedEmployee([], "1"), message));
            assert.throw(()=>(companyAdministration.firedEmployee([], []), message));
            assert.throw(()=>(companyAdministration.firedEmployee([], {}), message));
        })

        it("test with correct data", function(){
            let array = ["Petar", "Ivan", "George"];
            let index = 1;
            let output = "Petar, George";
            assert.equal(companyAdministration.firedEmployee(array, index), output);
        })

        it("test with number less than 0", function(){
            let message = "Invalid input";
            assert.throw(()=>(companyAdministration.firedEmployee([], -1), message));
        })

        it("test with number less than or equal to the length", function(){
            let message = "Invalid input";
            assert.throw(()=>(companyAdministration.firedEmployee(["Petar"], 1), message));
        })
    })
})

