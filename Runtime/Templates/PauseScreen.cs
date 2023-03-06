using GIG.Asset.Extensions;
using GIG.Asset.Templates.Abstract;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  public class PauseScreen :
    BaseScreen
  {
    public Button btnBack;
    public Button btnRestart;


    protected override void Awake()
    {
      base.Awake();
      btnBack.Action(() => { Hide(); });

      btnRestart.Action(() => SceneManager.LoadScene(0));
    }

    public override void Show()
    {
      base.Show();
      Time.timeScale = 0;
    }

    public override void Hide()
    {
      base.Hide();
      Time.timeScale = 1;
    }
  }
}