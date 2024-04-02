using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  /* public GameObject canvas1;
   [SerializeField] GameObject PausePanel;
   [SerializeField] GameObject Blocker;*/
  public void PlayGame()
  {
    SceneManager.LoadScene("SelectLevel");
  }
  public void StartGame()
  {
    SceneManager.LoadScene("Level1");
  }
  public void GoBack()
  {
    SceneManager.LoadScene("StartScene");
  }
  public void NextLevel()
  {
    SceneManager.LoadScene("Level2");
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
