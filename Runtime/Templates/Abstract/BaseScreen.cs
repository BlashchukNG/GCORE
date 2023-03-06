using Game;
using GIG.Asset.Controllers;
using GIG.Asset.Views;
using UnityEngine;

namespace GIG.Asset.Templates.Abstract
{
  public abstract class BaseScreen :
    MonoBehaviour,
    IScreen
  {
    protected BaseScreen _menu;
    
    protected UIView _view;
    protected GameController _gameController;
    protected SaveController _save;

    protected virtual void Awake()
    {
      _view = GetComponent<UIView>();
      _gameController = FindObjectOfType<GameController>();
      _save = FindObjectOfType<SaveController>();
      _menu = FindObjectOfType<MenuScreen>();
    }

    protected virtual void Start()
    {
    }

    public virtual void Show()
    {
      _view.Show();
    }

    public virtual void Hide()
    {
      _view.Hide();
    }
  }
}