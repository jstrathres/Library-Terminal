using Library_Terminal;
using System.ComponentModel.DataAnnotations;


bool runProgram = true;


List<Book> books = new List<Book>()
{
new Book("Rocky", "Stallone", true, DateTime.Now),
new Book("r", "r", true, DateTime.Now),
//new Book("", "", , ),
//new Book("", "", , ),
//new Book("", "", , ),
//new Book("", "", , )
//new Book("", "", , )
//new Book("", "", , )
//new Book("", "", , )
//new Book("", "", , )
//new Book("", "", , )
//new Book("", "", , )
//new Book("", "", , )
};


while (runProgram)
{
    Console.WriteLine("Welcome to the GC library. Please select an option");
    Console.WriteLine("1. View all books");
    Console.WriteLine("2. Search by author");
    Console.WriteLine("3. Search by title");
    Console.WriteLine("4. Quit");

    int choice = int.Parse(Console.ReadLine());
    if (choice ==1)
    {
        //Display all Books
        foreach (Book b in books)
        {
            Console.WriteLine($"{b.Title}|{b.Author}|{b.DueDate}");
        }
        Console.WriteLine("Would you like to check out a book? y/n");

    }
    else if (choice ==2)
    {
        //Search by author
        Console.Write("Please enter the author: ");
        string author = Console.ReadLine().ToLower().Trim();
        foreach (Book b in books.Where(b => b.Author.ToLower() == author))
        {
            Console.WriteLine($"{b.Title}");   
        }
    }
    else if (choice ==3)
    {
        //Search by title keyword
        Console.WriteLine("Please enter the title: ");
        string title = Console.ReadLine().ToLower().Trim();
        foreach (Book b in books.Where(b => b.Title.ToLower() == title))
        {
            Console.WriteLine($"{b.Title} by {b.Author}");   //might have to readjust all this, dunno what it means by "keyword"
        }
    }
    else if (choice ==4)
    {
        runProgram = false;
        Console.WriteLine("Goodbye");
    }


    runProgram = Library_Terminal.Validator.GetContinue("\nContinue?");


}
















