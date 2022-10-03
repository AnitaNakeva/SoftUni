function search() {
   let mySearch = document.getElementById("searchText").value;
   let count = 0;
   let lengthMySearch = mySearch.length;
   
   
   let towns = document.querySelectorAll('li');
   for(town of towns){
      let townAsString = town.textContent;
      if(townAsString.includes(mySearch)){
         town.style.fontWeight = "bold";
         town.style.textDecoration = "underline";
         count++;
      }
      else{
         town.style.fontWeight = "normal";
         town.style.textDecoration = "none";
      }
   };
   document.getElementById("result").textContent = count+" matches found";

   
}
