//Event handling

public class Button {

    //Defining an event
    public event EventHandler Clicked;

    //Method the fire the event
    protected virtual void OnClicked(EventArgs e){

        EventHandler handler = Clicked;
        handler?.Invoke(this, e);
    }


    //Simulate clicking the button
    public void Click(){
        OnClicked(EventArgs.Empty);
    }
}