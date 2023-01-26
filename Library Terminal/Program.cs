using Library_Terminal;

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

    int choice = int.Parse(Console.ReadLine());
    if (choice ==1)
    {
        //Display all Books
        foreach (Book b in books)
        {
            Console.WriteLine($"{b.Title}|{b.Author}|{b.DueDate}");
        }
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
    }


}
















