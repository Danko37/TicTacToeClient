public interface IView<in T>
{
    void Bind(T viewModel);
}