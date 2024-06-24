using System;

public class Property<T>
{
    private event Action<T> onChangeAction; 

    private T _value;
    public T Value { get=> _value;
        set
        {
            if (value.Equals(_value))
            {
                return;
            }

            _value = value;
            onChangeAction?.Invoke(_value);
        }
    }

    public Property()
    {
    }
    
    public Property(T startValue)
    {
        Value = startValue;
    }

    public void Subscribe(Action<T> cb)
    {
        onChangeAction += cb;
    }
    
    public void Unsubscribe(Action<T> cb)
    {
        onChangeAction -= cb;
    }

    public void ForceSet(T value)
    {
        _value = value;
        onChangeAction?.Invoke(_value);
    }
}
