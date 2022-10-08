function getArticleGenerator(articles) {
    let arr = Array.from(articles);
    let content = document.getElementById("content");

    function showArt(){
        if(arr.length===0){
            return;
        }
        let currentArt = arr.shift();
        content.innerHTML += '<article>'+currentArt+'</article>';
    }

    return showArt;
    /*return ()=>{
        if(arr.length===0){
            return;
        }
        let currentArt = arr.shift();
        content.innerHTML += '<article>'+currentArt+'</article>';
    }*/
}
