class List{
    constructor(){
        this.arr = [];
        this.size = this.arr.length;
    }

    add(number){
        this.arr.push(number);
        this.arr.sort((a,b)=>a-b);
        this.size++;
        return this.arr;
    }

    remove(index){
        if(index>=this.arr.length){
            throw new Error("error");
        }
        if(index<0){
            throw new Error("error");
        }
        this.arr.splice(index, 1);
        this.size--;
        return this.arr;
    }

    get(index){
        if(index>=this.arr.length){
            throw new Error("error");
        }
        if(index<0){
            throw new Error("error");
        }
        return this.arr[index];
    }
}

var myList = new List();
myList.add(5);
myList.add(3);
myList.remove(0);
console.log(myList.get(0));
console.log(myList.size);