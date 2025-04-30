public class Counter
{
    private int value = 0;
    public event EventHandler ThresholdReached;

    public void Increment(){
    value ++;
    if(value == 10 ) {
        ThresholdReached?.Invoke(this, EventArgs.Empty);
    }
    }
}