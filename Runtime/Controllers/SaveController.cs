using GCORE.Extensions;
using UnityEngine;

namespace GGCORE.Controllers
{
  public class SaveController :
    MonoBehaviour
  {
    public string key = "save";

    public T Load<T>()
      where T : new() =>
      PlayerPrefs.HasKey(key)
        ? PlayerPrefs.GetString(key).FromJson<T>()
        : new T();


    public void Save<T>(T data)
    {
      PlayerPrefs.SetString(key, data.TOJson());
    }
  }
}