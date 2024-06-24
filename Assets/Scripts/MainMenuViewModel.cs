using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuViewModel
{
  private Property<int> _property = new Property<int>(2);

  public MainMenuViewModel()
  {
    _property.Value = 3;
  }
}
