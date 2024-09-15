
// Representerer et bibliotek som kan inneholde forskjellige typer medier

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Library<T> : IStorable where T : Book, new()   
{
    private List<T> items = new List<T>();      // Liste for å holde medieelementer

    // Legger til et element i biblioteket
    public bool AddItem(T item)
    {
        if (!items.Any(b => b.ISBN == item.ISBN))
        {
            items.Add(item);
            return true; 
        }
        else
        {
            return false; 
        }
    }




    // Finner et element basert på et søkekriteria
    public T FindItem(Func<T, bool> searchPredicate)
    {
        return items.FirstOrDefault(searchPredicate);
    }


    // Viser elementer basert på et valgfritt søkekriteria
    public void DisplayItems(Func<T, bool> searchPredicate = null)
    {
        var filteredItems = searchPredicate == null ? items : items.Where(searchPredicate);
        foreach (var item in filteredItems)
        {
            item.DisplayInfo();
        }
    }


    // Lagrer bibliotekets tilstand til en fil
    public void SaveToFile(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var item in items)
            {
                writer.WriteLine($"{item.Title},{item.Author},{item.ISBN}");
            }
        }
    }


    // Fjerner et element fra biblioteket
    public bool RemoveItem(string isbn)
{
    var item = items.FirstOrDefault(b => b.ISBN == isbn);
    if (item != null)
    {
        items.Remove(item);
        Console.WriteLine($"Boken med ISBN {isbn} har blitt fjernet fra biblioteket."); // Informerer brukeren om at boken er fjernet
        return true; // Suksessfull fjerning
    }
    else
    {
        Console.WriteLine($"Ingen bok med ISBN {isbn} ble funnet i biblioteket."); // Informerer brukeren om at boken ikke ble funnet
        return false; // Mislykket forsøk på fjerning
    }
}


    // Henter bibliotekets tilstand fra en fil
    public void LoadFromFile(string filePath)
    {
        items.Clear();
        using (var reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    T item = new T
                    {
                        Title = parts[0],
                        Author = parts[1],
                        ISBN = parts[2]
                    };
                    items.Add(item);
                }
            }
        }
    }


    // Sjekker ut et element
    public void CheckoutItem(T item)
    {
    if (item.IsCheckedOut)
    {
        Console.WriteLine($"Boken '{item.Title}' er allerede utlånt.");
    }
    else
    {
        item.IsCheckedOut = true;
        Console.WriteLine($"Boken '{item.Title}' er nå sjekket ut.");
    }
    }


    // Returnerer et element
    public void ReturnItem(T item)
    {
    if (!item.IsCheckedOut)
    {
        Console.WriteLine($"Boken '{item.Title}' er allerede returnert.");
    }
    else
    {
        item.IsCheckedOut = false;
        Console.WriteLine($"Boken '{item.Title}' er nå returnert.");
    }
    }
}
