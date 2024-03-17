using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.SetTitle("Throne of Glass");
            book.SetAuthor("Sarah J. Maas");
            book.SetYearOfPublication(2012);
            book.SetPrice(5000);

            Console.WriteLine(book.DisplayInformation());

            book.IncreasePrice(10);

            Console.WriteLine(book.DisplayInformation());
        }
	}
}
