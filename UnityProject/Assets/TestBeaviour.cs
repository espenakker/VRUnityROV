using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBeaviour : MonoBehaviour {

	// Use this for initialization
	void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;
		for( int i = 0 ; i < devices.Length ; i++ )
			Debug.Log(devices[i].name);  
		WebCamTexture webcamTexture = new WebCamTexture();
		webcamTexture.deviceName = devices [1].name;
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
		
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (0,Mathf.Sin(Time.timeSinceLevelLoad)*2.5f,0);		
	}
}
