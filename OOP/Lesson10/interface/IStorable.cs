public interface IStorable
{
    void SaveToFile(string filePath);
    void LoadFromFile(string filePath);
}
