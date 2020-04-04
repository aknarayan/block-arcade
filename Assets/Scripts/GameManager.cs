using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

  private bool gameHasEnded = false;
  private bool collisionsOn;
  public float restartDelay = 1.0f;
  public float collisionDelay = 0.5f;
  public GameObject completeLevelUI;
  public Button pauseButton;
  public Button playButton;
  public Text levelText;
  public RectTransform collisionPanel;

  private void Start() {
    collisionsOn = true;
    levelText.text += (SceneManager.GetActiveScene().buildIndex - 1).ToString();
  }

  public void CompleteLevel() {
    completeLevelUI.SetActive(true);
  }

  public void Collide() {
    if (collisionsOn) {
      collisionPanel.GetComponent<Image>().gameObject.SetActive(true);
      Invoke("hideCollisionPanel", collisionDelay);
      collisionsOn = false;
    }
  }

  private void hideCollisionPanel() {
    collisionPanel.GetComponent<Image>().gameObject.SetActive(false);
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
    FindObjectOfType<AudioManager>().Pause("Theme");
    Time.timeScale = 0;
  }

  public void ResumeGame() {
    pauseButton.gameObject.SetActive(true);
    playButton.gameObject.SetActive(false);
    FindObjectOfType<AudioManager>().Resume("Theme");
    Time.timeScale = 1;
  }

}
