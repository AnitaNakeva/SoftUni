function solve(arr, criterion){
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let ticketArr = [];

    for(let i = 0; i < arr.length; i++){
        let info = arr[i].split("|");
        const ticket = new Ticket(info[0], Number(info[1]), info[2]);
        ticketArr.push(ticket);
    }

    let sortedTickets;
    if(criterion=="destination"){
        sortedTickets = ticketArr.sort(
            (t1, t2) => (t1.destination > t2.destination) ? 1 : (t1.destination < t2.destination) ? -1 : 0);
    }   
    else if(criterion=="price"){
        sortedTickets = ticketArr.sort(
            (t1, t2) => (t1.price > t2.price) ? 1 : (t1.price < t2.price) ? -1 : 0);
    } 
    else if(criterion=="status"){
        sortedTickets = ticketArr.sort(
            (t1, t2) => (t1.status > t2.status) ? 1 : (t1.status < t2.status) ? -1 : 0);
    }
    return sortedTickets;
}

console.log(solve(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'status'
));