function solve() {
    let input = document.getElementById("input");
    let output = document.getElementById("output");
    output.innerHTML="";
    let sentences = input.value.split(".").filter(x=>x.length>0);
    for(let i = 0; i<sentences.length; i+=3){
      let result = [];
      for(let j = 0; j<3; j++){
        if(sentences[i+j]){
            result.push(sentences[i+j]);
        }
      }
      let resultText=result.join(". ")+".";
      output.innerHTML+="<p>"+resultText+"</p>";
    }
  }