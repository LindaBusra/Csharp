public class CounterListener
{

    public void StartListening(Counter counter)
    {
        counter.ThresholdReached += OnThresholdReached;
    }

    private void OnThresholdReached(object sender, EventArgs e)
    {
        Console.WriteLine("Threshold reached!");
    }
}



