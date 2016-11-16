using UnityEngine;
using System.Collections;

public class WiggleLight : MonoBehaviour {
	void Update () {
		float portion = Mathf.Sin (Time.time / 2);
		transform.LookAt (Vector3.right * portion * 2);
	}
}