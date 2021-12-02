using System;

namespace Structure_Tutorial
{
    class Program
    {
        static void Main()
        {
            //StudentCreator();
            BookCreator();
        }

        private static void BookCreator()
        {
            Book book1 = new Book("Final Empire", "Sanderson. Brandon", "Fantasy", "2006\n");
            book1.Display();
            Book book2 = new Book("Count of Monte Cristo", "Dumas. Alexandre", "Classics", "1846");
            book2.Display();
        }

        private static void StudentCreator()
        {
            Student S1 = new Student();
            S1.ID = 401;
            S1.Name = "Serena";
            S1.PrintInfo();

            Student S2 = new Student();
            S2.ID = 403;
            S2.Name = "Calem";
            S2.PrintInfo();
        }
    }

    public struct Book
    {
        private string title, author, genre, year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Year { get => year; set => year = value; }

        public Book(string title, string author, string genre, string year)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {title} \nAuthor: {author} \nGenre: {genre} \nID: {year}");
        }
    }

    public struct Student
    {
        private int id;
        private string name;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }


        public Student(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }

        public void PrintInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}", this.id, this.name);
        }
    }
}
