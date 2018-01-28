using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTrigger(Collider other)
    {
        Debug.Log(other + " hit");
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z * -0.5f);
    }
}
