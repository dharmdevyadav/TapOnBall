using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel1 : MonoBehaviour
{
  [SerializeField] GameObject WonText;
  [SerializeField] GameObject RestartButton;
  [SerializeField] GameObject QuitButton;
  [SerializeField] GameObject CrossImage;
  UIManager uiScript;
  private float Score;

  public void Awake()
  {
    uiScript=FindObjectOfType<UIManager>();
  }
  public void Start()
  {
    RestartButton.SetActive(false);
    QuitButton.SetActive(false);
    CrossImage.SetActive(true);
    WonText.SetActive(false);
  }

  public void Won()
  {
    Score++;
    if (Score >=6)
    {
      uiScript.PauseButton.SetActive(false);
      CrossImage.SetActive(false);
      //uiScript.QuitImage.SetActive(false);
      WonText.SetActive(true);
      RestartButton.SetActive(true);
      QuitButton.SetActive(true);
      CrossImage.SetActive(false);
    }
  }
  public void RestartGame()
  {
    SceneManager.LoadScene("Level1");
  }
  public void QuitGame()
  {
    Application.Quit();
    Debug.Log("Quitted!!");
  }
}
