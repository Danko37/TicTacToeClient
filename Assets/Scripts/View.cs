public abstract class View<TViewModel> : ViewBase, IView<TViewModel>
{
    public abstract void Bind(TViewModel viewModel);

    public abstract void OnDisable();
}