using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View<MainMenuViewModel>
{
    [SerializeField] private Button _createRoomBtn;


    [SerializeField] private TextMeshProUGUI _createRoomBtnText;
    public override void Bind(MainMenuViewModel viewModel)
    {
        viewModel.CreateRoomBtnText.Subscribe(text => { _createRoomBtnText.text = text;});
        
        _createRoomBtn.onClick.AddListener(viewModel.CreateRoomCmd.Execute);
    }

    public override void OnDisable()
    {
       
    }
}
