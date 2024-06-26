
using UnityEngine;

public class MainMenuViewModel
{
  public Property<string> CreateRoomBtnText = new Property<string>();


  public Command CreateRoomCmd = new Command();

  public MainMenuViewModel()
  {
    CreateRoomBtnText.Value = "lalalal";
    
    CreateRoomCmd.Subscribe(() => {Debug.LogWarning(CreateRoomBtnText.Value);});
  }
}
