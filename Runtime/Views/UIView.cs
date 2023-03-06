using System.Collections;
using GIG.Asset.Extensions;
using UnityEngine;

namespace GIG.Asset.Views
{
  [RequireComponent(typeof(CanvasGroup))]
  public class UIView :
    MonoBehaviour
  {
    public StartCanvasActionType startAction;
    public float durationShow = 0.1f;
    public float durationHide = 0.1f;

    private Canvas _canvas;
    private CanvasGroup _group;

    private void Awake()
    {
      _canvas = GetComponent<Canvas>();
      _group = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
      _canvas.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

      switch (startAction)
      {
        case StartCanvasActionType.DoNothing:
          break;
        case StartCanvasActionType.DoShow:
          _canvas.Enable();
          break;
        case StartCanvasActionType.DoHide:
          _canvas.Disable();
          break;
      }
    }

    public void Show() => StartCoroutine(ShowCanvas(durationShow));
    public void Hide() => StartCoroutine(HideCanvas(durationHide));

    private IEnumerator ShowCanvas(float duration)
    {
      _canvas.Enable();
      yield return null;

      // var delay = duration / 50;
      //
      // while (_group.alpha < 1)
      // {
      //   _group.alpha += 0.02f;
      //   yield return new WaitForSecondsRealtime(delay);
      // }
    }

    private IEnumerator HideCanvas(float duration)
    {
      // var delay = duration / 50;
      //
      // while (_group.alpha > 0)
      // {
      //   _group.alpha -= 0.02f;
      //   yield return new WaitForSecondsRealtime(delay);
      // }

      yield return null;
      _canvas.Disable();
    }
  }
}