using UnityEngine;
using System.Collections;

public class SpinnerScript : MonoBehaviour {

	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (0, 30 * Time.deltaTime, 0));
	}
}
