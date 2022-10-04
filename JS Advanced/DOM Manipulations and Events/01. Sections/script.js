function create(words) {
   let elToAppendTo = document.getElementById('content');
   words.forEach(element => {
      let div = document.createElement('div');
      let para = document.createElement('p');
      para.textContent = element;
      para.style.display = 'none';
      div.addEventListener('click', onClick);
      function onClick(event){
         event.target.children[0].style.display = 'block';
      }
      div.appendChild(para);
      elToAppendTo.appendChild(div);
   });
}