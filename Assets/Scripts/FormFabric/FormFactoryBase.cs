public abstract class FormFactoryBase<T> where T : ViewModelBase
{
    public virtual string FormName { get; set; }
    public abstract void ShowForm(T viewModel);
}