using GIG.Asset.Extensions;
using GIG.Asset.Templates.Abstract;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  public class GameScreen :
    BaseScreen
  {
    protected override void Awake()
    {
      base.Awake();
    }


    protected override void Start()
    {
      foreach (var button in FindObjectsOfType<Button>())
      {
        button.Action(()=>DemoAudioManager.instance.PlayClipByIndex(0));
      }

      base.Start();
    }

    public override void Show()
    {
      base.Show();
    }

    public override void Hide()
    {
      base.Hide();
    }
  }
}