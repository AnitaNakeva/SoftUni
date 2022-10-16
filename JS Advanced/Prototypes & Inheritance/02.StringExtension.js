(function extendString(){
    let str = 'the quick brown fox jumps over the lazy dog' ;

    String.prototype.ensureStart = function(str){
        let doesItBegin = true;
        for(let i = 0; i<str.length; i++){
            if(this[i]!==str[i]){
                doesItBegin=false;
            }
        }
        let newStr = this;
        if(!doesItBegin){
            newStr = str+this;
        }

        return newStr;
    }

    String.prototype.ensureEnd = function(str){
        let doesItEnd = true;
        let k = 0;

        for(let i = this.length-str.length; i<this.length; i++){
            if(this[i]!==str[k]){
                doesItEnd=false;
            }
            k++;
        }

        let newStr = this;
        if(!doesItEnd){
            newStr = this+str;
        }

        return newStr;
    }

    String.prototype.isEmpty = function(){
        if(this.length===0){
            return true;
        }
        return false;
    }

    String.prototype.truncate = function(n){
        if(this.length<n){
            return this;
        }
        else{
            let splitStr = this.split(" ");
            if(splitStr.length===1){
                if(n<4){
                    let string = '';
                    for(let i = 0; i<n; i++){
                        string+='.';
                    }
                    return string;
                }
                else{
                    let string = '';
                    for(let i = 0; i<n-3; i++){
                        string+=this[i];
                    }
                    string+='...';
                    return string;
                }
            }
            else{
                let string = '';
                for(let i = 0; i<splitStr.length; i++){
                    let beforeStr = string;
                    if((string+=splitStr[i]).length+3<=n){
                        string=beforeStr;
                        string+=splitStr[i];
                        string+=' ';
                    }
                    else{
                        string = beforeStr;
                        
                        break;
                    }
                }
                let finalString = '';
                for(let i = 0; i<string.length-1; i++){
                    finalString+=string[i];
                }
                finalString+='...';
                return finalString;
                
            }
        }

    }

    String.format = function(string, ...params){
        let finalString = "";
        let k = 0;
    
        for(let i = 0; i < string.length; i++){
            if(string[i]==="{"){
                if(k<params.length){
                    finalString+=params[k];
                    i+=2;
                    k++;
                }
                else{
                    finalString+=string[i];
                }
            }
            else{
                finalString+=string[i];
            }
        }
        return finalString;
    }

    /*console.log(str = str.ensureStart('my'));
    console.log(str = str.ensureStart('hello '));
    console.log(str = str.truncate(16));
    console.log(str = str.truncate(14));
    console.log(str = str.truncate(8));
    console.log(str = str.truncate(4));
    console.log(str = str.truncate(2));
    console.log(str = String.format('The {0} {1} fox',
  'quick', 'brown'));
    console.log(str = String.format('jumps {0} {1}',
  'dog'));
*/
var answer = str.ensureStart('the ');
console.log(answer);
answer = answer.ensureStart('the ');
console.log(answer);
})()


