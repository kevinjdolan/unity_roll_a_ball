using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mover : MonoBehaviour {

	public Text countText;
	public Text winText;

	public float speed = 1f;
	private Rigidbody body;
	private int count;

	void Start () {
		this.body = this.GetComponent<Rigidbody> ();
		this.count = 0;
		this.SetUiState ();
	}
		
	void FixedUpdate () {
		float horizontalSpeed = Input.GetAxis ("Horizontal");
		float verticalSpeed = Input.GetAxis ("Vertical");
		this.body.AddForce (new Vector3 (this.speed * horizontalSpeed, 0, this.speed * verticalSpeed));
	}

	void OnTriggerEnter(Collider other) {
		GameObject obj = other.gameObject;
		if (obj.CompareTag ("Pickup")) {
			obj.SetActive (false);
			this.count += 1;
			this.SetUiState ();
		}
	}

	void SetUiState() {
		this.countText.text = "Score: " + this.count.ToString ();
		if (this.count >= 12) {
			this.winText.text = "You Win!";
		} else {
			this.winText.text = "";
		}
	}
}
