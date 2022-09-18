function wordsUppercase(text){
    let result = '';

    function isCharacterALetter(char) {
        return (/[a-zA-Z]/).test(char)
      }

    for(let i = 0; i<=text.length-2; i++){
        if(isCharacterALetter(text[i])){
            result+=text[i].toUpperCase();
        }
        if(text[i]===' '){
            result+=', ';
        }
        else if(text[i]==='.'&&text[i+1]!==' '){
            result+=', ';
        }
    }
    if(isCharacterALetter(text[text.length-1])){
        result+=text[text.length-1].toUpperCase();
    }

    console.log(result);
}

wordsUppercase('Functions in JS can be nested, i.e. hold other functions');