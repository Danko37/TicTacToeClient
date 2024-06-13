using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DIStart : MonoInstaller
{
    [SerializeField] private GameObject FormManager;
    
    public override void InstallBindings()
    {
        Container.Bind<FormsManager>().FromComponentInNewPrefab(FormManager).AsSingle();
        
    }
}
