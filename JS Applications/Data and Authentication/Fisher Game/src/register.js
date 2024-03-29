document.getElementById("register-form").addEventListener("submit", registerHandler)
document.querySelectorAll("a").forEach(x=>x.classList.remove("active"));
document.getElementById("register").classList.add("active");
document.getElementById("user").style.display = "none";
        
const errorP = document.querySelector("p.notification");

function registerHandler(e){
    //todo validation
    e.preventDefault();
    const form = e.target;
    const formData = new FormData(form);
    const {email, password, rePass} = Object.fromEntries(formData);

    if(password!==rePass){
        errorP.textContent = "Error";
        setTimeout(()=>{
            errorP.textContent = ""
        }, 1000)
    } else{
        onRegister(email, password);
    }
}

async function onRegister(email, password){
    const url = "http://localhost:3030/users/register"
    const body = {
        email,
        password
    }
    const header = getHeader("POST", body);
    try{
        const response = await fetch(url, header);
        const data =await response.json();
        if(data.code && data.code !== 200){
            console.log(data.code);
            console.log(data.code);
            throw new Error(data.message);
        }
        sessionStorage.setItem("email", data.email);
        sessionStorage.setItem("accessToken", data.accessToken);

        window.location = "./index.html";
        return data;
    }catch(e){
        errorP.textContent = e;
        setTimeout(()=>{
            errorP.textContent = "";
        }, 1000);
    }
    
}

function getHeader(method, body){
    return{
        method: `${method}`,
        headers:{
            "Content-Type": "application/json"
        },
        body: JSON.stringify(body)
    }
}