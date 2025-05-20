
/*

// Eksempelkode som illustrerer konseptet, ikke direkte anvendbar
public class WeakEventHandler<TEventArgs> where TEventArgs : EventArgs
{
    private WeakReference _targetRef;
    private MethodInfo _method;

    public WeakEventHandler(EventHandler<TEventArgs> handler)
    {
        _targetRef = new WeakReference(handler.Target);
        _method = handler.Method;
    }

    public void Invoke(object sender, TEventArgs e)
    {
        if (_targetRef.IsAlive)
        {
            _method.Invoke(_targetRef.Target, new object[] { sender, e });
        }
    }
}


*/