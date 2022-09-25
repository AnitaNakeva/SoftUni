function constCrew(obj){
    if(obj.dizziness===true){
        let bonusHidr = obj.weight*obj.experience*0.1;
        obj.levelOfHydrated+=bonusHidr;
        obj.dizziness=false;
    }

    return(obj);
}

constCrew({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  );