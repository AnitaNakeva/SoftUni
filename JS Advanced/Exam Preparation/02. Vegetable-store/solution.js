class VegetableStore{
    constructor(owner, location){
        this.owner = owner;
        this.location = location;
        this.availableProducts = [];
    }

    loadingVegetables(vegetables){
        let addedPr = [];

        for(let veg of vegetables){
            let splitVeg = veg.split(" ");
            let type = splitVeg[0];
            let quantity = Number(splitVeg[1]);
            let price = Number(splitVeg[2]);

            let vegetable = {
                type: type,
                quantity: quantity, 
                price: price
            }
            let isItThere = false;

            for(let i = 0; i<this.availableProducts.length; i++){
                if(this.availableProducts[i].type===type){
                    isItThere = true;
                    let q = this.availableProducts[i].quantity;
                    this.availableProducts[i].quantity = Number(q)+Number(quantity);
                    if(this.availableProducts[i].price<price){
                        this.availableProducts[i].price=price;
                    }
                }
            }

            if(!isItThere){
                addedPr.push(vegetable.type);
                this.availableProducts.push(vegetable);
            }
        }

        return "Successfully added " + addedPr.join(", ");
    }

    buyingVegetables(selectedProducts){
        let totalPrice = 0;
        for(let pr of selectedProducts){
            let splitPr = pr.split(" ");
            let type = splitPr[0];
            let quantity = splitPr[1];
            let isTherePr = false;
        
            for(let i = 0; i<this.availableProducts.length; i++){
                if(type===this.availableProducts[i].type){
                    isTherePr = true;
                    if(this.availableProducts[i].quantity>=quantity){
                        let currentPrice = this.availableProducts[i].price*quantity;
                        this.availableProducts[i].quantity-=quantity;
                        totalPrice+=currentPrice;
                        break;
                    }
                    else{
                        throw new Error(`The quantity ${quantity} for the vegetable ${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
                    }
                }
            }

            if(!isTherePr){
                throw new Error(`${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
            }

        }

        return `Great choice! You must pay the following amount $${totalPrice.toFixed(2)}.`;
    }

    rottingVegetable(type, quantity){
        let isItMissing = true;

        for(let i = 0; i<this.availableProducts.length; i++){
            if(this.availableProducts[i].type===type){
                isItMissing=false;
                if(this.availableProducts[i].quantity<quantity){
                    this.availableProducts[i].quantity=0;
                    return `The entire quantity of the ${type} has been removed.`;
                }
                else{
                    this.availableProducts[i].quantity-=quantity;
                    return `Some quantity of the ${type} has been removed.`;
                }
            }
        }

        if(isItMissing){
            throw new Error(`${type} is not available in the store.`);
        }
    }

    revision(){
        let buff = "";
        buff += "Available vegetables:\n";
        let ordered = this.availableProducts.sort((a, b)=>a.price-b.price);
        for(let i = 0; i<ordered.length; i++){
            buff+=ordered[i].type+'-'+ordered[i].quantity+'-$'+ordered[i].price+'\n';
        }
        buff+=`The owner of the store is ${this.owner}, and the location is ${this.location}.`;
        
        return buff;
    }
}

let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));
console.log(vegStore.rottingVegetable("Okra", 1));
console.log(vegStore.rottingVegetable("Okra", 2.5));
console.log(vegStore.buyingVegetables(["Beans 8", "Celery 1.5"]));
console.log(vegStore.revision());
