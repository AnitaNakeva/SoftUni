class footballTeam{
    constructor(clubName, country){
        this.clubName = clubName;
        this.country = country;
        this.invitedPlayers = [];
    }

    newAdditions(footballPlayers){
        let newPlayers = [];
        for(let i = 0; i < footballPlayers.length; i++){
            let name = footballPlayers[i].split('/')[0];
            let age = Number(footballPlayers[i].split('/')[1]);
            let playerValue = Number(footballPlayers[i].split('/')[2]);
        
            let player = this.invitedPlayers.find(x=>x.name===name);
            if(!player){
                player = {
                    name, age, playerValue
                };
                this.invitedPlayers.push(player);
                newPlayers.push(player.name);
            }
            else{
                if(player.playerValue<=playerValue){
                    player.playerValue = playerValue;
                }
            }
        }

        return `You successfully invite ${newPlayers.join(", ")}.`;
    }

    signContract(selectedPlayer){
        let name = selectedPlayer.split("/")[0];
        let playerOffer = Number(selectedPlayer.split("/")[1]);
        let player = this.invitedPlayers.find(x=>x.name===name);
        if(!player){
            throw new Error(`${name} is not invited to the selection list!`);
        }
        else if(player.playerValue>playerOffer){
            throw new Error(`The manager's offer is not enough to sign a contract with ${name}, ${player.playerValue-playerOffer} million more are needed to sign the contract!`);
        }
        else{
            player.playerValue = "Bought";
            return `Congratulations! You sign a contract with ${name} for ${playerOffer} million dollars.`;
        }
    }

    ageLimit(name, age){
        let ageLimit = Number(age);
        let player = this.invitedPlayers.find(x=>x.name===name);
        if(!player){
            throw new Error(`${name} is not invited to the selection list!`);
        }
        if(player.age<ageLimit){
            if((ageLimit-player.age)<5){
                return `${name} will sign a contract for ${ageLimit-player.age} years with ${this.clubName} in ${this.country}!`;
            }
            else{
                return `${name} will sign a full 5 years contract for ${this.clubName} in ${this.country}!`
            }
        }
        else{
            return `${name} is above age limit!`;
        }
    }

    transferWindowResult(){
        let buff = "Players list:\n";
        let orderedPlayers = this.invitedPlayers.sort((a, b) =>
        a.name.localeCompare(b.name));;
        for(let i = 0; i<orderedPlayers.length-1; i++){
            buff+=`Player ${orderedPlayers[i].name}-${orderedPlayers[i].playerValue}\n`;
        }
        if(this.invitedPlayers.length!==0){
            buff+=`Player ${orderedPlayers[orderedPlayers.length-1].name}-${orderedPlayers[orderedPlayers.length-1].playerValue}`;
        }
        return buff;
    }
}

let fTeam = new footballTeam("Barcelona", "Spain");
console.log(fTeam.newAdditions(["Kylian Mbappé/23/160", "Lionel Messi/35/50", "Pau Torres/25/52"]));
console.log(fTeam.signContract("Kylian Mbappé/240"));
console.log(fTeam.ageLimit("Kylian Mbappé", 30));
console.log(fTeam.transferWindowResult());
