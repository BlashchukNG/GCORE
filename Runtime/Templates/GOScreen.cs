using GIG.Asset.Extensions;
using GIG.Asset.Templates.Abstract;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  public class GOScreen :
    BaseScreen
  {
    public Button btnRestart;
    public Button btnQuit;

    public TMP_Text score, bscore;

    protected override void Awake()
    {
      base.Awake();
      btnRestart.Action(() => { SceneManager.LoadScene(1); });
      btnQuit.Action(() => SceneManager.LoadScene(0));
    }

    public override void Show()
    {
      base.Show();
      Time.timeScale = 0;
      DemoAudioManager.instance.PlayClipByIndex(2);

      score.text = $"{_gameController.score}";
      bscore.text = $"{_save.data.bestScore}";
    }

    public override void Hide()
    {
      base.Hide();
      Time.timeScale = 1;
    }
  }
}