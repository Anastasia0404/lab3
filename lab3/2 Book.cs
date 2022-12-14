using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Book
    {
        private string title;
        private string author;
        private string content;
        public Book(string title, string author, string content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
    }
    class Title
    {
        private string title;
        public string GSTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Title: {title}");
            Console.ResetColor();
        }
    }
    class Author
    {
        private string author;
        public string GSAuthor
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Author: {author}");
            Console.ResetColor();
        }
    }
    class Content
    {
        private string content;
        public string GSContent
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Content: {content}");
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();
            Console.Write("Введiть Title: ");
            title.GSTitle = Console.ReadLine();
            Console.Write("Введiть Author: ");
            author.GSAuthor = Console.ReadLine();
            Console.Write("Введiть Content: ");
            content.GSContent = Console.ReadLine();
            Book book = new Book(title.GSTitle, author.GSAuthor, content.GSContent);
            title.Show();
            author.Show();
            content.Show();
            Console.WriteLine("Нажмiть будь-яку клавiшу для завершення програми");
            Console.ReadKey();
        }
    }
}
