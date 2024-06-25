using System;

public class Command<T> : ICommand<T>
{
    private event Action<T> _observedEvent; 
    
    public void Subscribe(Action<T> cb)
    {
        _observedEvent += cb;
    }

    public void Unsubscribe(Action<T> cb)
    {
        _observedEvent -= cb;
    }

    public void Execute(T arg)
    {
        _observedEvent?.Invoke(arg);
    }
}


public class Command : ICommand
{
    private event Action _observedEvent; 
    
    public void Subscribe(Action cb)
    {
        _observedEvent += cb;
    }

    public void Unsubscribe(Action cb)
    {
        _observedEvent -= cb;
    }

    public void Execute()
    {
        _observedEvent?.Invoke();
    }
}
