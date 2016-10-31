using UnityEngine;
using System.Collections;

public class FollowPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "platform"){
		//	Collider compoundcollider = 
			transform.parent = collision.collider.transform;
		}
	}
//	void OnCollisionStay(Collision collision) {
//		if (collision.gameObject.tag == "platform") {
//			transform.parent = collision.collider.transform;
//		}
//	}
	void OnCollisionExit(Collision collision) {
		if(collision.gameObject.tag == "platform"){
			transform.parent = null;
		}
	}
}