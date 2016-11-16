using UnityEngine;
using System.Collections;

public class SpinCluster : MonoBehaviour {
	void Update () {
		transform.Rotate (Vector3.up * 15 * Time.deltaTime);
	}
}