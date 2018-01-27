using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysInFrontCamera : MonoBehaviour {
    [SerializeField] private Camera m_mainCamera;
	
	// Update is called once per frame
	void Update () {
        transform.position = m_mainCamera.transform.position + m_mainCamera.transform.forward * 1.0f;
	}
}
