using UnityEngine;

/// <summary>
/// Занимается только загрузкой форм
/// </summary>
public class FormLoader : MonoBehaviour
{
    private const string FORMS_PATH_PREFIX = "Forms/UI/";
    
    private Transform BackFormsRoot;
    private Transform FrontFormsRoot;
    
    public ViewBase LoadForm(string formName, FormModalType modalType)
    {
        var formPath = FORMS_PATH_PREFIX + formName;
        
        var form = Resources.Load<ViewBase>(formPath);
        
        var spawnedForm = Instantiate(form.gameObject, parent: modalType == FormModalType.Back ? BackFormsRoot : FrontFormsRoot).GetComponent<ViewBase>();

        return spawnedForm;
    }
}

public enum FormModalType
{
    Front,
    Back
}