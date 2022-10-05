function encodeAndDecodeMessages() {
    
    let button1 = document.getElementsByTagName("button")[0];
    let button2 = document.getElementsByTagName("button")[1];
    let div = document.getElementById("container");
    let texta1 = div.getElementsByTagName('textarea')[0];
    let texta2 = div.getElementsByTagName('textarea')[1];

    button1.addEventListener("click", onClick);
    button2.addEventListener("click", onClick2);

    function onClick(e){
    let textToEncode = texta1.value;
    let textToEndCodeInAscii = "";
    for(let i = 0; i<textToEncode.length; i++){
        let element = textToEncode[i].charCodeAt();
        element++;
        let result = String.fromCharCode(element);
        textToEndCodeInAscii+=result;
    }
    texta1.value = "";
    texta2.value = textToEndCodeInAscii;
    }

    function onClick2(e){
        let text = texta2.value;
        let result = "";
        for(let i = 0; i<text.length; i++){
            let element = text[i].charCodeAt();
            element--;
            let res = String.fromCharCode(element);
            result+=res;
        }

        texta2.value = result;
    }
}