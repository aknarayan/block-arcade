using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

  private bool gameHasEnded = false;
  public float restartDelay = 1.0f;
  public GameObject completeLevelUI;

  public void CompleteLevel() {
    completeLevelUI.SetActive(true);
  }

  public void EndGame() {
    if (!gameHasEnded) {
      gameHasEnded = true;
      Invoke("Restart", restartDelay);
    }
  }

  void Restart() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
