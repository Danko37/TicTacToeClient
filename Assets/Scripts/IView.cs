public interface IView<in T>
{
    void Bind(T viewModel);

    void OnDisable();
}