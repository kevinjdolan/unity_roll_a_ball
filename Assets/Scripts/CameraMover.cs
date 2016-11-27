using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	public GameObject target;
	private Vector3 offset;

	void Start () {
		this.offset = this.transform.position - this.target.transform.position;
	}

	void LateUpdate () {
		this.transform.position = this.target.transform.position + this.offset;
	}
}
