function solve(...params){
    let types = {};
    for(let param of params){
        let type = typeof param;
        if(types.hasOwnProperty(type)){
            types[type]++;
        }
        else{
            types[type] = 1;
        }

        console.log(type+": "+param);
    }

    let orderedTypes = Object.entries(types)
    .sort(([, a], [, b]) => b - a)
    .reduce(
      (r, [k, v]) => ({
        ...r,
        [k]: v
      }),
      {}
    );

    for(let type in orderedTypes){
        console.log(type+" = "+orderedTypes[type]);
    }
}

solve({ name: 'bob'}, 3.333, 9.999)