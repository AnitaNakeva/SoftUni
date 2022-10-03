function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);


   function onClick() {
      let tableRow = document.querySelectorAll("tbody tr");
      let textToSearch = document.getElementById("searchField").value;
      for(let i = 0; i<tableRow.length; i++){
         let tableData = tableRow[i].cells;
         for(let j = 0; j<tableData.length; j++){
            if(tableData[j].textContent.includes(textToSearch)){
               tableRow[i].classList.add('select');
               break;
            }
            else{
               if(tableRow[i].classList.contains('select')){
                  tableRow[i].classList.remove('select');
               }
            }
         }
      }

   }
}