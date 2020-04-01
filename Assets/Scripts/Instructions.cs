using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

  public void Back() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
}
