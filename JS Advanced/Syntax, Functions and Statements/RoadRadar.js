function roadRadar(speed, zone){
    let allowedSpeed;
    switch(zone){
        case 'motorway': allowedSpeed=130; break;
        case 'interstate': allowedSpeed=90; break;
        case 'city': allowedSpeed=50; break;
        case 'residential': allowedSpeed=20; break;
    }

    if(speed<=allowedSpeed){
        console.log(`Driving ${speed} km/h in a ${allowedSpeed} zone`);
    }
    else{
        let status;
        let speeding = speed-allowedSpeed;

        if(speeding<=20){
            status='speeding';
        }
        else if(speeding<=40){
            status='excessive speeding';
        }
        else{
            status='reckless driving';
        }

        console.log(`The speed is ${speeding} km/h faster than the allowed speed of ${allowedSpeed} - ${status}`);
    }
}

roadRadar(200, 'motorway');