using GIG.Asset.Extensions;
using GIG.Asset.Templates.Abstract;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  public class WinScreen :
    BaseScreen
  {
    public Button btnBack;
    public Button btnRestart;

    protected override void Awake()
    {
      base.Awake();
      btnBack.Action(() =>
      {
        SceneManager.LoadScene(0);
      });
      
      btnRestart.Action(()=>SceneManager.LoadScene(1));
    }

    public override void Show()
    {
      base.Show();
      DemoAudioManager.instance.PlayClipByIndex(0);
    }
  }
}