using GCORE.Extensions;
using GCORE.Views;
using UnityEngine;
using UnityEngine.UI;

namespace GIG.Asset.Templates
{
  [RequireComponent(typeof(UIView))]
  public class SimpleScreen :
    MonoBehaviour
  {
    public Button btnBack;

    private UIView _view;

    protected void Awake()
    {
      GetComponent<UIView>();

      if (btnBack != null) btnBack.Action(_view.Hide);
    }
  }
}