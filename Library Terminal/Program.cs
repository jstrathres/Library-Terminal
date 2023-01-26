using Library_Terminal;
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

//Display all Books
foreach (Book b in books)
{
    Console.WriteLine($"{b.Title}|{b.Author}|{b.DueDate}");
}

//Search by author

//Search by title keyword
