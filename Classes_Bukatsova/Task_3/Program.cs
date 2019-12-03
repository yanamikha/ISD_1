using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title(); 
            title.someText = "Little prince";

            Author author = new Author(); 
            author.someText = "Antoine de Saint-Exupery";

            Content content = new Content(); 
            content.someText = "Charper_1.....";

            Book book = new Book(title, author, content);

            title.Show();
            author.Show();
            content.Show();
            Console.ForegroundColor = ConsoleColor.White; 
        }
    }
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(Title title, Author author, Content content)
        {
           this.title = title;
           this.author = author;
           this.content = content;
        }
    }
    class Title
    {
        public string someText;
       public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(someText);
        }
    }
    class Author
    {
        public string someText;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(someText);
        }
    }
    class Content
    {
        public string someText;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(someText);
        }
    }
}
