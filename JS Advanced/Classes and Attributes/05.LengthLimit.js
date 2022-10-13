class Stringer{
    constructor(innerString, innerLength){
        this.innerString = innerString;
        this.innerLength = innerLength;
    }

    get innerLength(){
        return this._innerLength;
    }
    set innerLength(value){
        if(value>=0){
        this._innerLength=value;
        }
        else{
            this._innerLength=0;
        }
    }

    increase(length){
        this.innerLength+=length;
    }

    decrease(length){
        this.innerLength-=length;
    }

    toString(){
        if(this.innerString.length<=this.innerLength){
            return this.innerString;
        }
        else{
            let newString = "";
            for(let i = 0; i<this.innerLength; i++){
                newString+=this.innerString[i];
            }
            return newString+"...";
        }
    }
}

let test = new Stringer("Test", 5);
console.log(test.innerLength);
console.log(test.innerString);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); 
