using UnityEngine;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
  [SerializeField] GameObject LockImage;
  [SerializeField] Button Level2;
   
    void Update()
    {
    UnlockLevel();
    }
  public void UnlockLevel()
  {
    if (PlayerPrefs.GetInt("Level1")==1)
    {
      LockImage.SetActive(false);
      Level2.interactable = true;
    }
  }
}
