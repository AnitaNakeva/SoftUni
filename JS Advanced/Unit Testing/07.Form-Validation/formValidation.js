function validate() {
    let buttonSubmit = document.getElementById("submit");

    document.getElementById("company").addEventListener("click", function handleClick(){
        if (document.getElementById("company").checked){
            document.getElementById("companyInfo").style.display = "block";
        }
        else{
            document.getElementById("companyInfo").style.display = "none";
        }
    });

    buttonSubmit.addEventListener("click", function checkValidation(event){
        event.preventDefault();

        let wrongUsername = false;
    let wrongEmail = false;
    let wrongPassword = false;
    let wrongConfirmPassword = false;
    let wrongCompanyNumber = false;
    let wrongElement = false;

    if(document.getElementById("username").value.length<3){
        wrongUsername = true;
    }
    if(document.getElementById("username").value.length>20){
        wrongUsername = true;
    }
    for(let letter of document.getElementById("username").value){
        if(letter.toLowerCase() === letter.toUpperCase()){
            if(isNaN(letter)){
                wrongUsername = true;
                break;
            }
        }
    }

    if(document.getElementById("confirm-password").value!==document.getElementById("password").value){
        wrongConfirmPassword = true;
        wrongPassword = true;
    }
    if(document.getElementById("password").value.length<5){
        wrongPassword = true;
        wrongConfirmPassword=true;
    }
    if(document.getElementById("password").value.length>15){
        wrongPassword = true;
        wrongConfirmPassword = true;
    }
    for(let letter of document.getElementById("password").value){
        if(letter.toLowerCase() === letter.toUpperCase()){
            if(isNaN(letter)){
                if(letter!=="_"){
                wrongPassword = true;
                wrongConfirmPassword = true;
                break;
                }
            }
        }
    }

    let firstPartOfEmail = document.getElementById("email").value.split("@");
    if(firstPartOfEmail.length==2){
        let secondPartOfEmail = firstPartOfEmail[1].split(".");
        if(secondPartOfEmail.length!=2){
            wrongEmail = true;
        }
    }
    else{
        wrongEmail = true;
    }

    

    if(document.getElementById("companyInfo").style.display === "block"){
    if(document.getElementById("companyNumber").value<1000){
        wrongCompanyNumber = true;
    }
    if(document.getElementById("companyNumber").value>9999){
        wrongCompanyNumber = true;
    }
    }

    if(wrongUsername){
        document.getElementById("username").style.borderColor = "red";
        wrongElement=true;
    }
    else{
        document.getElementById('username').style.border = '';
    }
    

    if(wrongEmail){
        document.getElementById("email").style.borderColor = "red";
        wrongElement=true;
    }
    else{
        document.getElementById('email').style.border = '';
    }

    if(wrongPassword){
        document.getElementById("password").style.borderColor = "red";
        wrongElement=true;
    }
    else{
        document.getElementById('password').style.border = '';
    }

    if(wrongConfirmPassword){
        document.getElementById("confirm-password").style.borderColor = "red";
        wrongElement=true;
    }
    else{
        document.getElementById('confirm-password').style.border = '';
    }

    if(document.getElementById("companyInfo").style.display === "block"){
    if(wrongCompanyNumber){
        document.getElementById("companyNumber").style.borderColor = "red";
        wrongElement=true;
    }
    else{
        document.getElementById("companyNumber").style.border = '';
    }}

    if(!wrongElement){
        document.getElementById("valid").style.display = "block";
    }
    else{
        document.getElementById("valid").style.display = "none";
    }
})
}
