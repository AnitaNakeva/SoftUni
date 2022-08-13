namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void CheckIfConstructorWorks()
        {
            Assert.DoesNotThrow(() =>
            {
                Book book = new Book("Name", "Author");

                Assert.AreEqual("Name", book.BookName);
                Assert.AreEqual("Author", book.Author);
                Assert.AreEqual(0, book.FootnoteCount);
            });
        }

        [Test]
        public void BookAuthorProp()
        {
            Book book = new Book("name", "author");

            Assert.AreEqual("author", book.Author);
        }

        [Test]
        public void BookNameProp()
        {
            Book book = new Book("name", "author");

            Assert.AreEqual("name", book.BookName);
        }

        [TestCase(null)]
        [TestCase("")]
        public void BookNamePropWithWrongData(string bookName)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Book book = new Book(bookName, "author");
            });
        }

        [TestCase(null)]
        [TestCase("")]
        public void BookAuthorPropWithWrongData(string author)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Book book = new Book("bookName", author);
            });
        }

        [Test]
        public void AddFootNote()
        {
            Book book = new Book("name", "author");
            book.AddFootnote(11, "text");

            Assert.AreEqual(1, book.FootnoteCount);
        }

        [Test]
        public void AddTheSameFootNote()
        {
            Book book = new Book("name", "author");
            book.AddFootnote(11, "text");

            Assert.Throws<InvalidOperationException>(() =>
                {
                    book.AddFootnote(11, "otherText");
                });
        }

        [Test]
        public void FindFootnoteProp()
        {
            Book book = new Book("name", "author");
            book.AddFootnote(11, "text");

            string text = book.FindFootnote(11);

            Assert.AreEqual("Footnote #11: text", text);
        }

        [Test]
        public void FindFootnotePropWithMissingFootnote()
        {
            Book book = new Book("name", "author");
            book.AddFootnote(11, "text");

            Assert.Throws<InvalidOperationException>(() =>
            {
                book.FindFootnote(12);
            });
        }

        [Test]
        public void AlterFootnoteProp()
        {
            Book book = new Book("name", "author");
            book.AddFootnote(11, "text");

            book.AlterFootnote(11, "newText");

            Assert.AreEqual("Footnote #11: newText", book.FindFootnote(11));
        }

        [Test]
        public void AlterFootnotePropWithMissingFootnote()
        {
            Book book = new Book("name", "author");
            book.AddFootnote(11, "text");

            Assert.Throws<InvalidOperationException>(() =>
            {
                book.AlterFootnote(12, "newText");
            });
        }
    }
}