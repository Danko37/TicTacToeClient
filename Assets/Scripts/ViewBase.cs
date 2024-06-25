using UnityEngine;

public abstract class View<T> : MonoBehaviour , IView<T>
{
    public abstract void Bind(T viewModel);
}