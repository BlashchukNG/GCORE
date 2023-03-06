using GCORE.Extensions;
using UnityEngine;

namespace GCORE.Views
{
  [RequireComponent(typeof(CanvasGroup))]
  public class UIView :
    MonoBehaviour
  {
    public StartCanvasActionType startAction;

    private Canvas _canvas;

    private void Awake()
    {
      _canvas = GetComponent<Canvas>();
    }

    private void Start()
    {
      _canvas.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

      switch (startAction)
      {
        case StartCanvasActionType.DoNothing:
          break;
        case StartCanvasActionType.DoShow:
          Show();
          break;
        case StartCanvasActionType.DoHide:
          Hide();
          break;
      }
    }

    public void Show() => _canvas.Enable();
    public void Hide() => _canvas.Disable();
  }
}