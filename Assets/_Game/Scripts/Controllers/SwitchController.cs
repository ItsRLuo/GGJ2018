using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {

	public float smooth = 2.0F;
	private int isTurnOn = -1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnTriggerEnter(){
		Debug.Log (tag);
		if (tag == "UpDownSwitch") {
//			Quaternion target = Quaternion.Euler(0f, 0f, -30f);
//			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
			var rotationVector = transform.rotation.eulerAngles;
			rotationVector.z = 120 * isTurnOn;
			isTurnOn *= -1;
			transform.rotation = Quaternion.Euler (rotationVector);

		} else if (tag == "LeftRightSwitch"){
			var rotationVector = transform.rotation.eulerAngles;
			rotationVector.y = 30 * isTurnOn;
			isTurnOn *= -1;
			transform.rotation = Quaternion.Euler (rotationVector);
		}
	}
}
