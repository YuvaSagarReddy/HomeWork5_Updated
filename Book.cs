using System;
namespace Homework_5
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public Book(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished})";
        }
    }
    public class EBook:Book
    {
        public double Size { get; set; }

        public EBook(string title, string author, int yearPublished, double fileSizeMB): base(title, author, yearPublished)
        {
            Size = fileSizeMB;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished}) - EBook, Size: {Size}MB";
        }
    }

    public class PrintedBook:Book
    {
        public int Count { get; set; }

        public PrintedBook(string title, string author, int yearPublished, int pageCount)
            : base(title, author, yearPublished)
        {
            Count = pageCount;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished}) - Printed, Pages: {Count}";
        }
    }
}

