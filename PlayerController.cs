using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlaterController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	// Code for physics
	void FixedUpdate() {
		//code for moving horizontally/vertically/etc

	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Collectible")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
		if (other.gameObject.CompareTag ("Door")) {
			winText.text = "You've beaten the level!";
		}
		if (other.gameObject.CompareTag ("Clouds")) {
			winText.text = "You lose!";
		}
	}

	void SetCountText () {
		countText.text = "Count: " + count.ToString ();
		//add a conditional that does something if the count reaches a certain point
	}
	
}
