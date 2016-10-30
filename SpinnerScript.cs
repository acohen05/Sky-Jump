using UnityEngine;
using System.Collections;

public class SpinnerScript : MonoBehaviour {

	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (0, 50 * Time.deltaTime, 0));
	}
}
