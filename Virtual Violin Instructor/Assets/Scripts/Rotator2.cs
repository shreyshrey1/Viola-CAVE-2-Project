using UnityEngine;
using System.Collections;

public class Rotator2 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// Rotate the object around its local Y axis at 1 degree per second
		transform.Rotate(30*Vector3.up * Time.deltaTime);
	}
}
