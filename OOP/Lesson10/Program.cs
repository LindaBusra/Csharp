using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        Library<Book> library = new Library<Book>();
        string filePath = "library.txt";
        LoadLibraryData(library, filePath);

        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add Book 2. Remove Book 3. List Books and Ebooks 4. Search Books 5.Exit");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter 1 for Book, 2 for EBook");
                    var bookType = Console.ReadLine();

                    try
                    {
                        if (bookType == "1")
                        {
                            Console.WriteLine("Enter title, author and ISBN separated by commas:");
                            var bookInfo = Console.ReadLine().Split(',');
                            if (bookInfo.Length != 3) throw new ArgumentException("You must provide title, author and isbn.");
                            library.AddBook(new Book(bookInfo[0], bookInfo[1], bookInfo[2]));
                        }
                        else if (bookType == "2")
                        {
                            Console.WriteLine("Enter title, author, ISBN, Filepath and FileFormat separated by commas:");
                            var ebookInfo = Console.ReadLine().Split(',');
                            if (ebookInfo.Length != 5) throw new ArgumentException("You must provide title, author, isbn, filePath and FileFormat.");
                            library.AddBook(new EBook(ebookInfo[0], ebookInfo[1], ebookInfo[2], ebookInfo[3], ebookInfo[4]));
                        }
                        else
                        {
                            throw new ArgumentException("Invalid book type");
                        }
                        library.SaveToFile(filePath);
                        Console.WriteLine("Book added and library saved.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e}");
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Enter ISBN of book to remove");
                        var isbn = Console.ReadLine();
                        if (library.RemoveBook(isbn))
                        {
                            library.SaveToFile(filePath);
                            Console.WriteLine("Book removed and library updated");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e}");
                    }
                    break;

                case "3":
                
                    Console.WriteLine("Library books:");
                    foreach ( var book in library.GetAllBooks())
                    {
                        book.PrintInformation();
                    }
                    break;
                case "4":

                    try
                    {
                        LoadLibraryData(library, filePath);
                        Console.WriteLine("Enter search term,:");
                        var searchTerm = Console.ReadLine();
                        var foundBooks = library.SearchBooks(searchTerm);
                        if(foundBooks.Count > 0)
                        {
                            foreach(var item in foundBooks)
                            {
                                item.PrintInformation();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No Books found with searchterm {searchTerm}");
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                    break;
                case "5":
                    running = false;
                    break;
                default: 
                    Console.WriteLine("Invalid Option, please try again");
                    break;

            }
        }

    }

    private static void LoadLibraryData(Library<Book> library, string filePath)
    {
        try
        {
            library.LoadFromFile(filePath);
            Console.WriteLine("Library data loaded!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No Library data file found. A new one will be created upon adding books.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading library data: {e.Message}");
        }
    }
}




