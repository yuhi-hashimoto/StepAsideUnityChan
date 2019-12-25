using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Camera.main.gameObject.transform.position.z > this.transform.position.z) {
			Destroy (this.gameObject);
		}
	}
	/*	
	void OnBecameInvisible () {
		Destroy (this.gameObject);
	}*/
}
