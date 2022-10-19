class Garden{
    constructor(spaceAvailable){
        this.spaceAvailable = spaceAvailable;
        this.plants = [];
        this.storage = [];
    }

    addPlant(plantName, spaceRequired){
        if(this.spaceAvailable<spaceRequired){
            throw new Error("Not enough space in the garden.");
        }
        else{
            let plant = {
                plantName: plantName,
                spaceRequired: spaceRequired,
                ripe: false,
                quantity: 0
            };

            this.plants.push(plant);
            this.spaceAvailable-=spaceRequired;
            return `The ${plantName} has been successfully planted in the garden.`;
        }
    }

    ripenPlant(plantName, quantity){
        let plant = this.plants.find(x=>x.plantName===plantName);
        if(!plant){
            throw new Error(`There is no ${plantName} in the garden.`);
        }
        else if(plant.ripe){
            throw new Error(`The ${plantName} is already ripe.`);
        }
        else if(quantity<=0){
            throw new Error(`The quantity cannot be zero or negative.`);
        }
        else{
            plant.ripe = true;
            plant.quantity+=quantity;
            if(quantity===1){
                return `${quantity} ${plantName} has successfully ripened.`;
            }
            else{
                return `${quantity} ${plantName}s have successfully ripened.`;
            }
        }
    }

    harvestPlant(plantName){
        let plant = this.plants.find(x=>x.plantName===plantName);
        if(!plant){
            throw new Error(`There is no ${plantName} in the garden.`);
        }
        else if(!plant.ripe){
            throw new Error(`The ${plantName} cannot be harvested before it is ripe.`);
        }
        else{
            let filteredPlants = this.plants.filter(function(pl) {
                return pl.plantName !== plantName;
              });
              this.plants = filteredPlants;
            let plantToPush = {
                plantName: plant.plantName,
                quantity: plant.quantity
            };
            this.storage.push(plantToPush);
            this.spaceAvailable+=plant.spaceRequired;
            return `The ${plantName} has been successfully harvested.`;
        }
    }

    generateReport(){
        let buff = `The garden has ${this.spaceAvailable} free space left.\n`;
        buff+="Plants in the garden: ";
        let orderedPlants = this.plants.sort((a,b)=>a.plantName-b.plantName);
        for(let i = 0; i<orderedPlants.length-1; i++){
            buff+=orderedPlants[i].plantName+", ";
        }
        buff+=orderedPlants[orderedPlants.length-1].plantName;
        buff+="\n";
        if(this.storage.length===0){
            buff+="Plants in storage: The storage is empty.";
        }
        else{
            buff+="Plants in storage: ";
            for(let i = 0; i<this.storage.length-1; i++){
                buff+=this.storage[i].plantName+" ("+this.storage[i].quantity+"), ";
            }
            buff+=this.storage[this.storage.length-1].plantName+" ("+this.storage[this.storage.length-1].quantity+")";
        }

        return buff;
    }
}

const myGarden = new Garden(250)
console.log(myGarden.addPlant('apple', 20));
console.log(myGarden.addPlant('orange', 200));
console.log(myGarden.addPlant('raspberry', 10));
console.log(myGarden.ripenPlant('apple', 10));
console.log(myGarden.ripenPlant('orange', 1));
console.log(myGarden.harvestPlant('orange'));
console.log(myGarden.generateReport());
