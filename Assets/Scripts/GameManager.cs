using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

  private bool gameHasEnded = false;
  public float restartDelay = 1.0f;
  public GameObject completeLevelUI;
  public Button pauseButton;
  public Button playButton;

  public void CompleteLevel() {
    completeLevelUI.SetActive(true);
  }

  public void EndGame() {
    if (!gameHasEnded) {
      gameHasEnded = true;
      Invoke("Restart", restartDelay);
    }
  }

  private void Restart() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void PauseGame() {
    pauseButton.gameObject.SetActive(false);
    playButton.gameObject.SetActive(true);
    Time.timeScale = 0;
  }

  public void ResumeGame() {
    pauseButton.gameObject.SetActive(true);
    playButton.gameObject.SetActive(false);
    Time.timeScale = 1;
  }

}
