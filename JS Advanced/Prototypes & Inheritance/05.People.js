function solution(){
    class Employee{
        constructor(name, age){
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
            this.taskNum = 0;
        };

        get salary(){
            return this._salary;
        }
        set salary(value){
            this._salary=value;
        }

        get taskNum(){
            return this._taskNum;
        }
        set taskNum(value){
            if(value===this.tasks.length){
                value=0;
            }
            this._taskNum=value;
        }

        work(){
            console.log(this.tasks[this.taskNum]);
            this.taskNum++;
        };
        

        collectSalary(){
            console.log(this.name+" received "+this.salary+" this month.");
        };
    }

    class Junior extends Employee{
        constructor(name, age){
            super(name, age)
            this.tasks = [""+this.name+" is working on a simple task."];
        };
    }

    class Senior extends Employee{
        constructor(name, age){
            super(name, age)
            this.tasks = [""+this.name+" is working on a complicated task.", this.name+" is taking time off work.", this.name+" is supervising junior workers."];
        };
    }

    class Manager extends Employee{
        constructor(name, age){
            super(name, age)

            this.dividend = 0;
            this.tasks = [""+this.name+" scheduled a meeting.", this.name+" is preparing a quarterly report."];
        };

        get dividend(){
            return this._dividend;
        }
        set dividend(value){
            this._dividend=value;
        }

        collectSalary(){
            let endSalary = this.salary+this.dividend;
            console.log(this.name+" received "+endSalary+" this month.");
        }
    }

    return{
        Employee, Junior, Senior, Manager
    };
}

const classes = solution (); 
const junior = new classes.Junior('Ivan',25); 
 
junior.work();  
junior.work();  
 
junior.salary = 5811; 
junior.collectSalary();  
 
const sinior = new classes.Senior('Alex', 31); 
 
sinior.work();  
sinior.work();  
sinior.work();  
sinior.work();  
 
sinior.salary = 12050; 
sinior.collectSalary();  
 
const manager = new classes.Manager('Tom', 55); 
 
manager.salary = 15000; 
manager.collectSalary();  
manager.dividend = 2500; 
manager.collectSalary();  

