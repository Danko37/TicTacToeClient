using System;

public interface IObserved
{
    void Subscribe(Action cb);
    
    void Unsubscribe(Action cb);
}

public interface IObserved<T>
{
    void Subscribe(Action<T> cb);

    void Unsubscribe(Action<T> cb);
}