using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
  [SerializeField] GameObject PausePanel;
  [SerializeField] GameObject Blocker;
  public GameObject QuitImage;
  public GameObject PauseButton;
  

  public void Pause()
  {
    //Instantiate(canvas1,transform.position,Quaternion.identity);
    Time.timeScale = 0;
    Blocker.SetActive(true);
    PausePanel.SetActive(true);
    QuitImage.SetActive(false);
    PauseButton.SetActive(false);
  }
  public void Resume()
  {
    Time.timeScale = 1;
    Blocker.SetActive(false);
    PausePanel.SetActive(false);
    QuitImage.SetActive(true);
    PauseButton.SetActive(true);
  }
  public void MainMenuButton()
  {
    Time.timeScale = 1;
    SceneManager.LoadScene("SelectLevel");
  }
  public void Restart()
  {
    Time.timeScale = 1;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
