//https://github.com/jstrathres/Library-Terminal


using Library_Terminal;
using System.ComponentModel.DataAnnotations;


bool runProgram = true;
 

List<Book> books = new List<Book>()
{
new Book("ROCKY", "SYLVESTER STALLONE", true, DateTime.Now),
new Book("SPACE", "BETH ARTHUR", false, DateTime.Now),
new Book("HISTORY", "GEORGE WASHINGTON",false,DateTime.Now),
new Book("PENGUINS", "JOHN ARTHUR", true, DateTime.Now),
new Book("LORD OF THE RINGS", "JOHN TOLKIEN", true, DateTime.Now),
new Book("WAR AND PEACE", "LEO TOLSTOY", false, DateTime.Now),
new Book("THE GREAT GATSBY", "SCOTT FITZGERALD", true, DateTime.Now),
new Book("MIDDLEMARCH", "GEORGE ELLIOTT", true, DateTime.Now),
new Book("THE ADVENTURES OF HUCKLEBERRY FINN", "MARK TWAIN", false, DateTime.Now),
new Book("IN SEARCH OF LOST TIME", "MARCEL PROUST", true, DateTime.Now),
new Book("HAMLET", "WILLIAM SHAKESPEARE", true, DateTime.Now),
new Book("MOBY DICK", "HERMAN MELVILLE", true, DateTime.Now),
new Book("ULYSESS", "JAMES JOYCE", true, DateTime.Now)
};


while (runProgram)
{
    Console.WriteLine("Welcome to the GC library. Please select an option");
    Console.WriteLine("1. View all books");
    Console.WriteLine("2. Search by author");
    Console.WriteLine("3. Search by title");
    Console.WriteLine("4. Check out a book");
    Console.WriteLine("5. Return a book");
    Console.WriteLine("6. Quit");

    

  
    int choice = Library_Terminal.Validator.GetUserNumberInt();

    if (choice == 1)
    {
        //Display all Books
        foreach (Book b in books)
        {
            Console.WriteLine($"{b.Title}|{b.Author}");
            
        }
    }
    else if (choice == 2)
    {
        //Search by author
        Console.Write("Please enter the author: ");
        string author = Console.ReadLine().ToUpper().Trim();
        foreach (Book b in books.Where(b => b.Author.ToUpper() == author))
        {
            Console.WriteLine($"{b.Title} by {b.Author}");
            if (b.Author.ToUpper() == author && b.Status == true)
            {
                Console.WriteLine("This book is available to check out");
            }
            else
            {
                Console.WriteLine("This book is not available to check out");
            }
        }
    }
    else if (choice == 3)
    {
        //Search by title keyword
        Console.Write("Please enter the title: ");
        string title = Console.ReadLine().ToUpper().Trim();
        foreach (Book b in books.Where(b => b.Title.ToUpper() == title))
        {
            Console.WriteLine($"{b.Title} by {b.Author}");   //might have to readjust all this, dunno what it means by "keyword"
            if (b.Title.ToUpper() == title && b.Status == true)
            {
                Console.WriteLine("This book is available to check out");
            }
            else
            {
                Console.WriteLine("This book is not available to check out");
            }
        }
    }
    else if (choice == 4) //check out a book
    {
        string BookChoice = "";
        Console.WriteLine("Which book would you like to check out?");
        BookChoice = Console.ReadLine().ToUpper().Trim();
        foreach (Book b in books)
        {
            if (b.Title.ToUpper() == BookChoice && b.Status == true)
            {
                b.DueDate = b.DueDate.AddDays(14);
                Console.WriteLine($"Ok, your due date is: {b.DueDate}");
                books.First(b => b.Title.ToUpper() == BookChoice).Status = false;
                break;
            }
            else if (b.Title.ToUpper() == BookChoice && b.Status == false)
            {
                Console.WriteLine("Sorry, this isn't available.");
                break;
            }
        }



    }
    else if (choice == 5) //return a book
    {
        string ReturnBook = "";
        Console.WriteLine("Which book would you like to return?");
        ReturnBook = Console.ReadLine().ToUpper().Trim();
        //if the book exists in library
        if (books.Any(b => b.Title.ToUpper() == ReturnBook))
        {
            
            Book SelectedBook = books.First(b => b.Title.ToUpper() == ReturnBook);
            if(SelectedBook.Status == false)
            {
                Console.WriteLine("Ok thanks");
                //updating status of book
                books.First(b => b.Title.ToUpper() == ReturnBook).Status = true;
                SelectedBook.DueDate = DateTime.Now;
            }
            else
            {
                Console.WriteLine("This book has already been returned.");
            }
            
        }
        else
        {
            Console.WriteLine("This book is not in the library");
        }


    }
    else if (choice == 6)
    {
        runProgram = false;
        Console.WriteLine("Goodbye");
        break;
    }


    runProgram = Library_Terminal.Validator.GetContinue("\nContinue?");


}
















