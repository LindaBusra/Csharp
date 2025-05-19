public class Button
{
    // Definere Eventet
    public event EventHandler Clicked;

    // Metode for å klikke på knappen
    public void Click()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}
