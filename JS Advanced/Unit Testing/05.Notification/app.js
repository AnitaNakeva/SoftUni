function notify(message) {
  let hiddenDiv = document.getElementById("notification");
  hiddenDiv.textContent = message;
  hiddenDiv.style.display="block";

  hiddenDiv.addEventListener("click", hideIt);
}

function hideIt(e){
  e.target.style.display="none";
}

