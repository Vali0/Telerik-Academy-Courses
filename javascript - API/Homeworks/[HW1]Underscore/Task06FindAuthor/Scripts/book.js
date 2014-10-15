/// <reference path="libs/underscore-min.js" />
(function () {
    var Book = (function () {
        function Book(title, author) {
            this.title = title,
            this.author = author
        }

        return Book;
    }());

    var books = [
        new Book('Inferno', 'Dan Brown'),
        new Book('Red Dragon', 'Thomas Harris'),
        new Book('The Silence of the Lambs', 'Thomas Harris'),
        new Book('The Da Vinci Code', 'Dan Brown'),
        new Book('Hannibal', 'Thomas Harris'),
        new Book('Hannibal Rising', 'Thomas Harris')
    ];

    var authorName = findMostPopularAuthor(books);
    console.log('Most popular author is: '+ authorName);

    function findMostPopularAuthor(books) {
        var mostPopularAuthors = [],
            booksPerAuthor,
            booksByMostPopularAuthor;

        booksPerAuthor = _.countBy(books, function (book) {
            return book.author;
        });
        
        booksByMostPopularAuthor = _.max(booksPerAuthor);

        for (var item in booksPerAuthor) {
            if (booksPerAuthor[item] === booksByMostPopularAuthor) {
                mostPopularAuthors.push(item);
            }
        }

        return mostPopularAuthors;
    }
}())