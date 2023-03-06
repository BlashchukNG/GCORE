using System;
using GIG.Asset.Extensions;
using UnityEngine;

namespace GIG.Asset.Controllers
{
  public class SaveController :
    MonoBehaviour
  {
    public SaveData data;
    public string key = "save";

    private void Awake()
    {
      data = PlayerPrefs.HasKey(key)
                   ? PlayerPrefs.GetString(key).FromJson<SaveData>()
                   : new SaveData();
    }


    private void OnDestroy() => Save();


    public void Save()
    {
      PlayerPrefs.SetString(key, data.TOJson());
    }
  }

  [Serializable]
  public sealed class SaveData
  {
    public int bestScore;
  }
}