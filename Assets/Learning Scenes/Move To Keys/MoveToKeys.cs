using UnityEngine;
using System.Collections;

public class MoveToKeys : MonoBehaviour {
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			hover ();
		}
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
	}

	void hover() {
		GetComponent<Rigidbody> ().AddForce (Vector3.up * 0.5f, ForceMode.Impulse);
	}

	void move(Vector3 moveDirection) {
		transform.position = transform.position + moveDirection / 10.0f;
	}
}