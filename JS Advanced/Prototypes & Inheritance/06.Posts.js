function solve(){
    class Post{
        constructor(title, content){
            this.title = title;
            this.content = content;
        }

        toString(){
            let string = "Post: "+this.title + "\n" + "Content: "+this.content;
            return string;
        }
    }

    class SocialMediaPost extends Post{
        constructor(title, content, likes, dislikes){
            super(title, content)

            this.likes = likes;
            this.dislikes = dislikes;

            this.comments = [];
        }

        addComment(comment){
            this.comments.push(comment);
        }

        toString(){
            let rating = this.likes-this.dislikes;
            let string = "Post: "+this.title + "\n" + "Content: "+this.content+"\n"+"Rating: "+rating;
            if(this.comments.length!==0){
                string+="\n";
                let commentsStr = "Comments: "+"\n";
                let lastComment = this.comments.pop();
                
                for(let i = 0; i<this.comments.length; i++){
                    commentsStr+=" * "+this.comments[i]+"\n";
                }
                commentsStr+=" * "+lastComment;
                string+=commentsStr;
            }
            return string;
        }
    }

    class BlogPost extends Post{
        constructor(post, content, views){
            super(post, content);
            this.views = views;
        }

        view(){
            this.views++;
            return this;
        }

        toString(){
            let string = "Post: "+this.title + "\n" + "Content: "+this.content+"\n"+"Views: "+this.views;
            return string;
        }
    }

    let p = new Post("fv", "fwev");
    console.log(p.toString());
    let s = new SocialMediaPost("gg", "gerg", 5, 4);
    s.addComment("fsgsdb");
    s.addComment("fweg");
    console.log(s.toString());
    let b = new BlogPost("vvv", "ff", 3);
    b.view();
    b.view();
    console.log(b.toString());

}

solve();