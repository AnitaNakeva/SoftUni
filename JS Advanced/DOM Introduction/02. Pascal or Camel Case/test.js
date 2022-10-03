function name(text){
    let textArray=text.split(" ");
    let result = "";
    for(let i = 1; i<textArray.length; i++){
        let currentWord = textArray[i].toUpperCase();
        result+=currentWord[0];
        currentWord = currentWord.toLowerCase();
        let lengthOfWord = currentWord.length;
        for(let j = 1; j<lengthOfWord;j++){
            result+=currentWord[j];
        }
    }
    console.log(result);
}

name("voov ergerg re");