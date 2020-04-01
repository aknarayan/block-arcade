using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

  public void StartGame() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
  }

  public void ShowInstructions() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

}
