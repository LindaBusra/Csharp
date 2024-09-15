
// Definerer metoder for lagring og henting fra fil

public interface IStorable
{
    void SaveToFile(string filePath); // Lagre til fil
    void LoadFromFile(string filePath); // Hente fra fil
}