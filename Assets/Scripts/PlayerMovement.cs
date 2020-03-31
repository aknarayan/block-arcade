using UnityEngine;

public class PlayerMovement : MonoBehaviour {

  public Rigidbody rb;
  public float forwardForce = 2000f;
  public float sidewaysForce = 500f;

  void FixedUpdate() {
    rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    if (Input.GetKey(KeyCode.D)) {
      rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    } else if (Input.GetKey(KeyCode.A)) {
      rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (rb.position.y < -1f) {
      FindObjectOfType<GameManager>().EndGame();
    }

  }
}
