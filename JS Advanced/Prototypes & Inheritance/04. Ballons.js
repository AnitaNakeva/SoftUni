function solve(){

    class Balloon{
        constructor(color, hasWeight){
            this.color = color;
            this.hasWeight = hasWeight;
        }
    }

    class PartyBalloon extends Balloon{
        constructor(color, hasWeight, ribbonColor, ribbonLength){
            super(color, hasWeight)

            this.ribbonColor = ribbonColor;
            this.ribbonLength = ribbonLength;
            this._ribbon = {};
            this._ribbon[ribbonColor] = this.ribbonColor;
            this._ribbon[ribbonLength] = this.ribbonLength;
        }

        _ribbon;

        get ribbon(){
            return this._ribbon;
        }
    }

    class BirthdayBalloon extends PartyBalloon{
        _text;
        constructor(color, hasWeight, ribbonColor, ribbonLength, text){
            super(color, hasWeight, ribbonColor, ribbonLength)

            this._text = text;
        }

        get text(){
            return this._text;
        }
    }

    return{
        Balloon,
        PartyBalloon,
        BirthdayBalloon
    }

}
solve();
let classes = solve();
let testBalloon = new classes.Balloon("yellow", 20.5);
let testPartyBalloon = new classes.PartyBalloon("yellow", 20.5, "red", 10.25);
let ribbon = testPartyBalloon.ribbon;
console.log(testBalloon);
console.log(testPartyBalloon);
console.log(ribbon);
