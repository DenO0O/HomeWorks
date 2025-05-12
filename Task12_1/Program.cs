using System;

namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
                {
                    new Book<string, int>("F-1200", "Книга 1", 1991, "И.О. Автор1"),
                    new Book<string, int>("F-1234", "Книга 2", 1992, "И.О. Автор2"),
                    new Book<string, int>("F-1245", "Книга 3", 1993, "И.О. Автор3"),
                };

            Book<int, string>[] books2 = new Book<int, string>[]
                {
                    new Book<int, string>(40, "Книга 1", "1900", "И.О. Автор1"),
                    new Book<int, string>(41, "Книга 2", "1900", "И.О. Автор2"),
                    new Book<int, string>(42, "Книга 3", "1900", "И.О. Автор3"),
                };

            Console.WriteLine(FindBook<string, int>(books1, "F-1234"));
            Console.WriteLine(FindBook<int, string>(books2, 42));
            Console.ReadKey();
        }

        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                {
                    return book;
                }
            }
            return null;
        }
    }

    class Book<T, U>
    {
        public T Code { get; set; }

        public string Title { get; set; }

        public U PublicationYear { get; set; }

        public string Author { get; set; }

        public Book(T code, string title, U publicationYear, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }
    }
}
