function heroicInv(arr){
    let res = [];

    for(const hero in arr){
        let [name, level, items] = hero.split(' / ');
        level = Number[level];
        items = items ? items.split(', ') : [];
            let obj = {
              name: name,
              level: level,
              items: items,
            };
            res.push(obj);
          
    }

    console.log(JSON.stringify(res));
}

heroicInv(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
);