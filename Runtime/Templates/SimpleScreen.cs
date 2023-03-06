using GIG.Asset.Extensions;
using GIG.Asset.Templates.Abstract;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  public class SimpleScreen :
    BaseScreen
  {
    public Button btnBack;


    protected override void Awake()
    {
      base.Awake();
      btnBack.Action(Hide);
    }
  }
}