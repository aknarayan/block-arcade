using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
  public Transform player;
  public Text scoreText;

  // Update is called once per frame
  void Update() {
    int score = (int)player.position.z;
    if (score >= 350) {
      scoreText.text = "350";
    } else {
      scoreText.text = score.ToString();
    }
  }
}
