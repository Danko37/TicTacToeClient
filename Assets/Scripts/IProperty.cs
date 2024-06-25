public interface IProperty<T> : IObserved<T>
{
    void ForceSet(T value);
}