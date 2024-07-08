using UnityEngine;
using Zenject;

public class DiStart : MonoInstaller
{
    [SerializeField] private GameObject FormManager;
    
    public override void InstallBindings()
    {
        BindServices();
        Container.Bind<App>().AsSingle().NonLazy();
    }

    private void BindServices()
    {
        Container.Bind<FormLoader>().FromComponentInNewPrefab(FormManager).AsSingle();
        Container.Bind<MainMenuFactory>().AsSingle();
    }
}
