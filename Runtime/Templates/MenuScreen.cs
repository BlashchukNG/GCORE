using GIG.Asset.Extensions;
using GIG.Asset.Templates.Abstract;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  public class MenuScreen :
    BaseScreen
  {
    public Button btnPlay;

    protected override void Awake()
    {
      base.Awake();

      btnPlay.Action(() => { SceneManager.LoadScene(1); });
      
      foreach (var button in FindObjectsOfType<Button>())
      {
        button.Action(()=>DemoAudioManager.instance.PlayClipByIndex(0));
      }
    }

    protected override void Start()
    {
      base.Start();
    }


    public override void Show()
    {
      base.Show();
    }
  }
}