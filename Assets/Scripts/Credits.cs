using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

  public void Quit() {
    Application.Quit();
  }

  public void Menu() {
    SceneManager.LoadScene(0);
  }
}
