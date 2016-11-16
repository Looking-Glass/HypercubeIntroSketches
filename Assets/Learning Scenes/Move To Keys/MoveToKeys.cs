using UnityEngine;
using System.Collections;

public class MoveToKeys : MonoBehaviour {
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			move(Vector3.right);
		}
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
			move(Vector3.forward);
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			move(Vector3.left);
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
			move(Vector3.back);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 5, ForceMode.Impulse);
		}
	}

	void move(Vector3 moveDirection) {
		transform.position = transform.position + moveDirection / 7.5f;
	}
}