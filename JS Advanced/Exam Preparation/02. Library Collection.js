class LibraryCollection{
    constructor(capacity){
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor){
        if(this.books.length>=this.capacity){
            throw new Error("Not enough space in the collection.");
        }
        let book = {
            bookName,
            bookAuthor,
            payed: false
        }
        this.books.push(book);
        return `The ${bookName}, with an author ${bookAuthor}, collect.`;
    }

    payBook(bookName){
        let bookToPay = this.books.find(x=>x.bookName===bookName);
        if(!bookToPay){
            throw new Error(`${bookName} is not in the collection.`);
        }
        else if(bookToPay.payed){
            throw new Error(`${bookName} has already been paid.`);
        }
        else{
            bookToPay.payed=true;
            return `${bookName} has been successfully paid.`;
        }
    }

    removeBook(bookName){
        let bookToRemove = this.books.find(x=>x.bookName===bookName);
        if(!bookToRemove){
            throw new Error("The book, you're looking for, is not found.");
        }
        else if(!bookToRemove.payed){
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }
        else{
            let newBooks = [];
            for(let i = 0; i<this.books.length; i++){
                if(this.books[i].bookName!==bookName){
                    newBooks.push(this.books[i]);
                }
            }
            this.books = newBooks;
            return `${bookName} remove from the collection.`;
        }
    }

    getStatistics(bookAuthor){
        if(!bookAuthor){
            let buff = `The book collection has ${this.capacity-this.books.length} empty spots left.\n`;
            let orderedBooks = this.books.sort((a, b) =>
            a.bookName.localeCompare(b.bookName));
            for(let i = 0; i<orderedBooks.length-1; i++){
                if(orderedBooks[i].payed){
                    buff+=`${orderedBooks[i].bookName} == ${orderedBooks[i].bookAuthor} - Has Paid.\n`
                }
                else{
                    buff+=`${orderedBooks[i].bookName} == ${orderedBooks[i].bookAuthor} - Not Paid.\n`
                }
            }
            if(this.books.length!==0){
                if(orderedBooks[orderedBooks.length-1].payed){
                    buff+=`${orderedBooks[orderedBooks.length-1].bookName} == ${orderedBooks[orderedBooks.length-1].bookAuthor} - Has Paid.`
                }
                else{
                    buff+=`${orderedBooks[orderedBooks.length-1].bookName} == ${orderedBooks[orderedBooks.length-1].bookAuthor} - Not Paid.`
                }
            }
            return buff;
        }
        else{
            let isItThere = false;
            let buff = "";
            for(let i = 0; i<this.books.length; i++){
                if(this.books[i].bookAuthor===bookAuthor){
                    if(this.books[i].payed){
                        buff+=`${this.books[i].bookName} == ${this.books[i].bookAuthor} - Has Paid.`
                    }
                    else{
                        buff+=`${this.books[i].bookName} == ${this.books[i].bookAuthor} - Not Paid.`
                    }
                    isItThere=true;
                }
            }
            if(isItThere){
                return buff;
            }
            else{
                throw new Error(`${bookAuthor} is not in the collection.`);
            }
        }
    }
}

