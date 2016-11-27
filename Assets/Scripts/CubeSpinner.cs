using UnityEngine;
using System.Collections;

public class CubeSpinner : MonoBehaviour {

	private Rigidbody body;
	public float rotationSpeed = 100f;

	void Start () {
		this.body = this.GetComponent<Rigidbody> ();
		Vector3 rotation = new Vector3 (
           Random.Range (0.0f, 1.0f) * 360,
           Random.Range (0.0f, 1.0f) * 360,
           Random.Range (0.0f, 1.0f) * 360
       );
		this.transform.Rotate(rotation);
	}

	void FixedUpdate () {
		Vector3 rotation = new Vector3 (
			Random.Range (-1.0f, 1.0f) * this.rotationSpeed,
			Random.Range (-1.0f, 1.0f) * this.rotationSpeed,
			Random.Range (-1.0f, 1.0f) * this.rotationSpeed
		);
		this.body.AddTorque (rotation);
	}
}
