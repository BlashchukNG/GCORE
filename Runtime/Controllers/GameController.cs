using System.Collections.Generic;
using GIG.Asset.Controllers;
using GIG.Asset.Templates;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
  public class GameController :
    MonoBehaviour
  {
    public SaveController save;
    public GOScreen go;

    public float speed;

    public int score;

    public TMP_Text sc; 

    private void Start()
    {
      StartGame(true);
    }


    public void StartGame(bool restart = false)
    {
      if (restart)
      {
        Time.timeScale = 1;
        FindObjectOfType<Spawner>().Play();
      }
    }

    private void Update()
    {
      speed += Time.deltaTime * 0.1f;

      score = (int)speed;
      if (save.data.bestScore < score) save.data.bestScore = score;

      sc.text = $"Score: {score}";
    }

    private bool CheckBlockUI()
    {
      PointerEventData pointerData = new PointerEventData(EventSystem.current);

      pointerData.position = Input.mousePosition;
      return CheckCanvas(pointerData);
    }

    private bool CheckCanvas(PointerEventData pointerData)
    {
      if (EventSystem.current == null) return false;

      List<RaycastResult> results = new List<RaycastResult>();
      EventSystem.current.RaycastAll(pointerData, results);

      if (results.Count > 0)
        foreach (var result in results)
          if (result.gameObject.GetComponent<CanvasRenderer>())
          {
            return true;
          }

      return false;
    }


    public void GameOver()
    {
      FindObjectOfType<GOScreen>().Show();
    }
  }
}