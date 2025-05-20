public class Library<T> : IStorable where T : Book
{
    private List<T> items = new List<T>();
    private Dictionary<string, bool> checkedOutBooks = new Dictionary<string, bool>();


    public List<T> GetAllBooks()
    {
        return items;
    }
    public void AddBook(T item)
    {
        items.Add(item);
    }

    public bool RemoveBook(string isbn)
    {
        var item = items.Find(b => b.ISBN.Trim() == isbn.Trim());
        if (item?.ISBN != null)
        {
            items.Remove(item);
            return true;
        }
        return false;
    }

    public bool CheckOutBook(string isbn)
    {
        if (items.Any(item => item.ISBN == isbn && !checkedOutBooks.ContainsKey(isbn)))
        {
            checkedOutBooks[isbn] = true;
            return true;
        }
        return false;
    }

    public bool ReturnBook(string isbn)
    {
        if (checkedOutBooks.ContainsKey(isbn))
        {
            checkedOutBooks.Remove(isbn);
            return true;
        }
        return false;
    }

    public void SaveToFile(string filePath)
    {
        var lines = items.Select(item =>
        {
            var typeIndicator = item is EBook ? "EBook" : "Book";
            var baseInfo = $"{item.Title}|{item.Author}|{item.ISBN}";
            if (item is EBook eBook)
            {
                return $"{typeIndicator}|{baseInfo}|{eBook.FilePath}|{eBook.FileFormat}";
            }
            return $"{typeIndicator}|{baseInfo}";
        }).ToArray();
        File.WriteAllLines(filePath, lines);
    }

    public void LoadFromFile(string filePath)
    {
        items.Clear();

        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if(parts[0] == "Book" && parts.Length == 4)
            {
                var newBook = new Book(parts[1], parts[2],parts[3]);
                items.Add((T)newBook);
            }
            else if(parts[0] == "EBook" && parts.Length == 6)
            {
                var newEBook = new EBook(parts[1], parts[2], parts[3],parts[4], parts[5]);
                items.Add((T)(object)newEBook);
            }
            else
            {
                throw new FormatException("Invalid book format in file.");
            }
        }
    }

    public void SortByTitle()
    {
        items.Sort((x,y) => x.Title.CompareTo(y.Title));
    }

    public List<T> SearchBooks(string searchTerm)
    {
        return items.Where(item => item.Title.ToLower().Contains(searchTerm.ToLower()) || item.Author.ToLower().Contains(searchTerm.ToLower())).ToList();
    }
}