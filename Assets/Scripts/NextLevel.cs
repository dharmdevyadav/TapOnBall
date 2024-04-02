using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NextLevel : MonoBehaviour
{
  public GameObject Balls;
  public GameObject WonText;
  public GameObject RestartButton;
  public GameObject NextButton;
  public GameObject QuitButton;
  public GameObject CrossImage;
  UIManager uiScript;
  public float Score;
  public void Awake()
  {
    uiScript = FindObjectOfType<UIManager>();
  }
  public void Start()
  {
    Balls.SetActive(true);
    CrossImage.SetActive(true);
    WonText.SetActive(false);
    NextButton.SetActive(false);
    RestartButton.SetActive(false);
    QuitButton.SetActive(false);
  }
  public void WonGame()
  {
    Score++;
    if (Score > 5)
    {
      PlayerPrefs.SetInt("Level1", 1);
      uiScript.PauseButton.SetActive(false);
      CrossImage.SetActive(false);
      WonText.SetActive(true);
      NextButton.SetActive(true);
      RestartButton.SetActive(true);
      QuitButton.SetActive(true);

    }
  }

}
