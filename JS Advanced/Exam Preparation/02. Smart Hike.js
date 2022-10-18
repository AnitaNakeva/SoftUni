class SmartHike{
    constructor(username){
        this.username = username;
        this.goals = {};
        this.listOfHikes = [];
        this.resources = 100;
    }

    addGoal(peak, altitude){
        if(!this.goals.hasOwnProperty(peak)){
            this.goals[peak] = altitude;
            return `You have successfully added a new goal - ${peak}`;
        }
        else{
            return `${peak} has already been added to your goals`;
        }
    }

    hike(peak, time, difficultyLevel){
        if(!this.goals.hasOwnProperty(peak)){
            throw new Error(`${peak} is not in your current goals`);
        }
        else{
            if(this.resources === 0){
                throw new Error("You don't have enough resources to start the hike");
            }
            else{
                let difference = this.resources - time * 10;
                if(difference<0){
                    return "You don't have enough resources to complete the hike";
                } 
                else{
                    this.resources-=time*10;
                    let hike = {
                        peak, 
                        time,
                        difficultyLevel
                    }
                    this.listOfHikes.push(hike);
                    return `You hiked ${peak} peak for ${time} hours and you have ${this.resources}% resources left`;
                }
            }
        }
    }

    rest(time){
        this.resources += time*10;
        if(this.resources>=100){
            this.resources>=100;
            return `Your resources are fully recharged. Time for hiking!`;
        }
        else{
            return `You have rested for ${time} hours and gained ${time*10}% resources`;
        }
    }

    showRecord(criteria){
        if(this.listOfHikes.length===0){
            return `${this.username} has not done any hiking yet`
        }
        else if(criteria==="hard"){
            let hardHikes = [];
            for(let i = 0; i < this.listOfHikes.length; i++){
                if(this.listOfHikes[i].difficultyLevel==="hard"){
                    hardHikes.push(this.listOfHikes[i]);
                }
            }

            if(hardHikes.length===0){
                return `${this.username} has not done any ${criteria} hiking yet`
            }
            let orderedHardHikes = hardHikes.sort((a, b)=>a.time - b.time);
            let bestHike = orderedHardHikes[0];
            return `${this.username}'s best ${criteria} hike is ${bestHike.peak} peak, for ${bestHike.time} hours`;
        }
        else if(criteria==="easy"){
            let easyHikes = [];
            for(let i = 0; i < this.listOfHikes.length; i++){
                if(this.listOfHikes[i].difficultyLevel==="easy"){
                    easyHikes.push(this.listOfHikes[i]);
                }
            }

            if(easyHikes.length===0){   
                return `${this.username} has not done any ${criteria} hiking yet`
            }
            let orderedEasyHikes = easyHikes.sort((a, b)=>a.time - b.time);
            let bestHike = orderedEasyHikes[0];
            return `${this.username}'s best ${criteria} hike is ${bestHike[peak]} peak, for ${bestHike.time} hours`;
        }
        else{
            let buff = "All hiking records:\n";
            for(let i = 0; i<this.listOfHikes.length; i++){
                buff+=`${this.username} hiked ${this.listOfHikes[i].peak} for ${this.listOfHikes[i].time} hours\n`;
            }

            return buff.substring(0, buff.length-1);
        }
    }
}


const user = new SmartHike('Vili');
user.addGoal('Musala', 2925);
user.hike('Musala', 8, 'hard');
console.log(user.showRecord('easy'));
user.addGoal('Vihren', 2914);
user.hike('Vihren', 4, 'hard');
console.log(user.showRecord('hard'));
user.addGoal('Rui', 1706);
user.hike('Rui', 3, 'easy');
console.log(user.showRecord('all'));
