function validate(obj){
    let methods = ["GET", "POST", "DELETE", "CONNECT"];
    let uriPattern = /^[\w.]+$/g;
    let versions = ["HTTP/0.9", "HTTP/1.0", "HTTP/1.1", "HTTP/2.0"];
    let specialChar = ["<", ">", "\\", "&", "'", '"'];

    if(!methods.includes(obj.method)){
        throw new Error("Invalid request header: Invalid Method");
    }
    if(!obj.hasOwnProperty("method")){
        throw new Error("Invalid request header: Invalid Method");
    }

    if(!obj.hasOwnProperty("uri")){
        throw new Error("Invalid request header: Invalid URI");
    }
    if(obj.uri===""){
        throw new Error("Invalid request header: Invalid URI");
    }
    if(!obj.uri.match(uriPattern)&&obj.uri!=="*"){
        throw new Error("Invalid request header: Invalid URI");
    }

    if(!obj.hasOwnProperty("version")){
        throw new Error("Invalid request header: Invalid Version");
    }
    if(!versions.includes(obj.version)){
        throw new Error("Invalid request header: Invalid Version");
    }

    if(!obj.hasOwnProperty("message")){
        throw new Error("Invalid request header: Invalid Message");
    }
    for(let ch of obj.message){
        if(specialChar.includes(ch)){
            throw new Error("Invalid request header: Invalid Message");
        }
    }
    

    return obj;
}

validate({

    method: 'GET',
    
    uri: 'svn.public.catalog',
    
    version: 'HTTP/1.1',
    
    message: ''
    
    });