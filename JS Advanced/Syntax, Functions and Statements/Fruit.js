function fruitPrize(fruit, grams, price){
    let kg = grams*0.001;
    let endPrice = kg*price;

    console.log(`I need $${endPrice.toFixed(2)} to buy ${kg.toFixed(2)} kilograms ${fruit}.`);
}

fruitPrize('apple', 1563, 2.35);