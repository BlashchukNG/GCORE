using GIG.Asset.Controllers;
using TMPro;
using UnityEngine;

namespace Game.AlpinoMobile._GIG.Asset.Controllers
{
  public class ScoreController :
    MonoBehaviour
  {
    public SaveController save;
    public TMP_Text[] txts;

    private void Update()
    {
      foreach (var t in txts)
        t.text = $"Best score: {save.data.bestScore}";
    }
  }
}