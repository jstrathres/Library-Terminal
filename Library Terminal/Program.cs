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
new Book("HUCKLEBERRY FINN", "MARK TWAIN", false, DateTime.Now),
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
    Console.WriteLine("7. Ashes to Ashes");

    int choice = Library_Terminal.Validator.GetUserNumberInt();

    if (choice == 1)
    {
        Console.WriteLine(String.Format("{0,-25}  {1,-25} {2,-25}", "Title", "Author", "Availability"));
        Console.WriteLine(String.Format("{0,-25}  {1,-25} {2,-25}", "=====", "======", "============"));
        //Display all Books
        foreach (Book b in books)
        {
            Console.WriteLine(string.Format("{0,-25} {1,-25} {2,-25}", b.Title, b.Author, b.statusCheck()));
        }

    }
    else if (choice == 2)
    {
        //Search by author
        string author = "";
        while (true)
        {
            Console.Write("Please enter the author: ");
            author = Console.ReadLine().ToUpper().Trim();
            if (books.Any(b => b.Author.ToUpper().Contains(author)))
            {
                foreach (Book b in books.Where(b => b.Author.ToUpper().Contains(author)))
                {
                    Console.WriteLine($"{b.Title} by {b.Author}");
                    if (b.Author.ToUpper().Contains(author) && b.Status == true)
                    {
                        Console.WriteLine("This book is available to check out");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This book is not available to check out");
                        break;
                    }
                }

                break;
            }
        }

    }
    else if (choice == 3)
    {
        //Search by title keyword
        string title = "";
        while (true)
        {
            Console.Write("Please enter the title: ");
            title = Console.ReadLine().ToUpper().Trim();
            if (books.Any(b => b.Title.ToUpper().Contains(title)))
            {
                foreach (Book b in books.Where(b => b.Title.ToUpper().Contains(title)))
                {
                    Console.WriteLine($"{b.Title} by {b.Author}");
                    if (b.Title.ToUpper().Contains(title) && b.Status == true)
                    {
                        Console.WriteLine("This book is available to check out");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This book is not available to check out");
                        break;
                    }
                }

                break;
            }
        }

    }
    else if (choice == 4) //check out a book
    {
        string BookChoice = "";
        while (true)
        {
            Console.WriteLine("Which book would you like to check out?");
            BookChoice = Console.ReadLine().ToUpper().Trim();
            if (books.Any(b => b.Title.ToUpper().Contains(BookChoice)))
            {
                foreach (Book b in books)
                {
                    if (b.Title.ToUpper().Contains(BookChoice) && b.Status == true)
                    {
                        Console.WriteLine($"Did you mean {b.Title} by {b.Author}?");
                        string yesOrNo = Console.ReadLine();
                        if (yesOrNo == "yes")
                        {
                            b.DueDate = b.DueDate.AddDays(14);
                            Console.WriteLine($"Ok, your due date is: {b.DueDate}");
                            books.First(b => b.Title.ToUpper().Contains(BookChoice)).Status = false;
                            break;
                        }
                        else if(yesOrNo == "y")
                        {
                            b.DueDate = b.DueDate.AddDays(14);
                            Console.WriteLine($"Ok, your due date is: {b.DueDate}");
                            books.First(b => b.Title.ToUpper().Contains(BookChoice)).Status = false;
                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                    else if (b.Title.ToUpper().Contains(BookChoice) && b.Status == false)
                    {
                        Console.WriteLine("Sorry, this isn't available.");
                        break;
                    }
                }

                break;
            }
        }

    }
    else if (choice == 5) //return a book
    {
        string ReturnBook = "";
        Console.WriteLine("Please list the full book title you would you like to return");

        ReturnBook = Console.ReadLine().ToUpper().Trim();
        //if the book exists in library

        if (books.Any(b => b.Title.ToUpper()== ReturnBook))
        {
            Book SelectedBook = books.First(b => b.Title.ToUpper()==ReturnBook);
            if (SelectedBook.Status == false)
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
    else if (choice == 7)
    {
        runProgram = false;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("");

        Console.WriteLine("                                          *");
        Console.WriteLine("                                           *");
        Console.WriteLine("                                           ***");
        Console.WriteLine("                                           ****");
        Console.WriteLine("                                           ****** *");
        Console.WriteLine("                                           **** *****");
        Console.WriteLine("                                          ****  *******");
        Console.WriteLine("                                    *    *****   *******");
        Console.WriteLine("                                     *   ******   *******       *");
        Console.WriteLine("                                     **  ******    *******     *");
        Console.WriteLine("                                     *** ******      *******   **");
        Console.WriteLine("                                     *** *****       *******  ***");
        Console.WriteLine("                                 *    ******          ******  *****");
        Console.WriteLine("                                 **   *****           *****  ****** ");
        Console.WriteLine("                                 **  *****             ****   ******");
        Console.WriteLine("                             *  ********              **************");
        Console.WriteLine("                            ** ********                * ************");
        Console.WriteLine("                           ***********                 *************");
        Console.WriteLine("                           ***********                 ***********");
        Console.WriteLine("                            ***********              ***********");
        Console.WriteLine("                             ***********           ***********");
        Console.WriteLine("                              *************       ***************");
        Console.WriteLine("                               ********************************       ");
        Console.WriteLine("                           ***************************************         ");
        Console.WriteLine("                                           Goodbye");
        break;
    }
    runProgram = Library_Terminal.Validator.GetContinue("\nContinue?");
    Console.Clear();
}