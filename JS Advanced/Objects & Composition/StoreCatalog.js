function storeCat(arr){
    let res = [];
    let letters = [];
for(let product of arr){
    [name, price]=product.split(':');
    let obj = {name:name, price:price};
    if(!letters.some(x=>x==name[0])){
        letters.push(name[0]);
    }

    res.push(obj);
}

letters.sort();
for(let i = 0; i<letters.length; i++){
    for(let j = 0; j<res.length; j++){
        if(res[j][name[0]]==letters[i]){
            console.log(res[j]);
        }
    }
}

}

storeCat(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
);