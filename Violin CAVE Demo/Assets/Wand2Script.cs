using UnityEngine;
using System.Collections;

public class Wand2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = getReal3D.Input.GetSensor("Wand2").position;
        transform.rotation = getReal3D.Input.GetSensor("Wand2").rotation;

    }
}
