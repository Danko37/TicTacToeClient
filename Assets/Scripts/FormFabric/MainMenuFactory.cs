using Zenject;

public class MainMenuFactory :  FormFactoryBase<MainMenuViewModel>
{
    public override string FormName { get; set; } = "MainMenu";

    [Inject]
    public void Construct(FormLoader formLoader)
    {
        
    }

    public override void ShowForm(MainMenuViewModel viewModel)
    {
        
    }
}