using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float time = 3.0f; // Arbitrary number
	TextMesh tm;

	void Start ()
    {
		tm = GetComponent<TextMesh>();
	}
	void Update () {
		time -= Time.deltaTime;
		if(time > 0)
        {
			//If time is greater than 0, display time left
			tm.text = Mathf.RoundToInt(time).ToString();
		}
        else
		{
			//Otherwise display this
			tm.text = "GO";
		}

	}
}