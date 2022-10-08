function calculator() {
    let selector1;
    let selector2;
    let resultSelector;

    let action = {
        init: (firstSelector, secondSelector, resSelector)=>{
            selector1 = document.querySelector(firstSelector);
            selector2 = document.querySelector(secondSelector);
            resultSelector = document.querySelector(resSelector);
        },
        add: ()=>{
            let num1 = Number(selector1.value);
            let num2 = Number(selector2.value);
            let sum = num1+num2;
            resultSelector.value = sum;
        },
        subtract: ()=>{
            let num1 = Number(selector1.value);
            let num2 = Number(selector2.value);
            let subtraction = num1-num2;
            resultSelector.value = subtraction;
        },
    }

    return action;
}

const calculate = calculator ();

calculate.init ('#num1', '#num2', '#result');



