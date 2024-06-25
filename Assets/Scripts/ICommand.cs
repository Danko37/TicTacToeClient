public interface ICommand : IObserved
{
    void Execute();
}

public interface ICommand<T> : IObserved<T>
{
    void Execute(T arg);
}