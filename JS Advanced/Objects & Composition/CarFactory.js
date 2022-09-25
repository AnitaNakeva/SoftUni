function carFact(obj){
    let res = {};

    res.model = obj.model;
    
    if(obj.power<=90){
        res.engine = {power:90,
            volume:1800};
    }
    else if(obj.power<=120){
        res.engine = {power:120,
            volume:2400};
    }
    else{
        res.engine = {power:200,
            volume:3500};
    }

    if(obj.carriage=='hatchback'){
        res.carriage={type:'hatchback',
        color:obj.color};}
    else{
        res.carriage={type:'coupe',
            color:obj.color};
    }   
    let wheelssize = obj.wheelsize;
    if(obj.wheelsize%2==0){
    wheelssize--;}

    let wheels = [wheelssize, wheelssize, wheelssize, wheelssize];
    res.wheels = wheels;

    console.log(res);
}

carFact({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14}
);