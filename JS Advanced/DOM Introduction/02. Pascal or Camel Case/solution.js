function solve() {
  let text = document.getElementById("text").value;
  let convention = document.getElementById("naming-convention").value;
  let textArray = text.split(" ");
  let result = "";

  if(convention==="Camel Case"){
    result = textArray[0].toLowerCase();
    for(let i = 1; i<textArray.length; i++){
      let currentWord = textArray[i].toUpperCase();
      result+=currentWord[0];
      currentWord = currentWord.toLowerCase();
      let lengthOfWord = currentWord.length;
      for(let j = 1; j<lengthOfWord;j++){
          result+=currentWord[j];
      }
  }
  }
  else if(convention==="Pascal Case"){
    for(let i = 0; i<textArray.length; i++){
      let currentWord = textArray[i].toUpperCase();
      result+=currentWord[0];
      currentWord = currentWord.toLowerCase();
      let lengthOfWord = currentWord.length;
      for(let j = 1; j<lengthOfWord;j++){
          result+=currentWord[j];
      }
  }
  }
  else{
    result="Error!";
  }

  document.getElementById("result").textContent=result;
}
