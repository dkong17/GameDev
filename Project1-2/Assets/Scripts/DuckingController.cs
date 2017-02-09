using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingController : MonoBehaviour {

	GameObject big;

	// Use this for initialization
	void Awake () {
		if (this.name == "Ducking Star") {
			big = GameObject.Find("Star Mario");
		}
		else {
			big = GameObject.Find("Super Mario");
		}
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Vertical")) {
            big.SetActive(true);
			big.transform.position = new Vector3(this.transform.position.x, big.transform.position.y);
            Vector3 scale = this.gameObject.transform.localScale;
            scale.x = scale.x * Mathf.Sign(scale.x);
            this.gameObject.transform.localScale = scale;
            this.gameObject.SetActive(false);
        }		
	}
}
