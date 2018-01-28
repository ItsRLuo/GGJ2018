using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushButton : MonoBehaviour {
    bool locked = false;
    // Use this for initialization
    void Start () {
     }
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider other)
    {
        if (this.locked == false)
        {
            this.gameObject.SetActive(false);
            this.locked = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        this.locked = false;
    }
}
