using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushControllers : MonoBehaviour {
    // Use this for initialization
	void Start () {
        foreach (Transform child in transform)
        {
            if (child.name.Contains("Circle")){
                child.gameObject.AddComponent<BoxCollider>();
                var trigger = child.gameObject.GetComponent<BoxCollider>();
                child.gameObject.AddComponent<Rigidbody>();
                var body = child.gameObject.GetComponent<Rigidbody>();
                body.useGravity = false;
                trigger.isTrigger = true;
                child.gameObject.AddComponent<pushButton>();
            }
            
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
