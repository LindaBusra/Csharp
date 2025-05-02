
//En genrisk klasse med en begrensning som krever at T må være en referansetype og ha en parameterløs konstruktør
public class GenericRepository<T> where T : class, new()

{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

//Simulerer henting av et element basert på en ID
//Dette er en forenklet eksempel og vil ikke fungere i en ekte applikasjon 
    public T GetById(int id)
    {
        return _items[id];
    }


    public T CreateNew()
    {
        return new T();
    }
}