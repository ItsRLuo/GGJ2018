using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushButton : MonoBehaviour {
    bool locked;
    // Use this for initialization
    void Start () {
        Debug.Log("Asd");
    }
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("qqq");
        this.gameObject.SetActive(false);
    }
}
