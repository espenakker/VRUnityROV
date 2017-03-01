using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBeaviour : MonoBehaviour {
	static string othercam = "";
	// Use this for initialization
	void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;
		WebCamTexture webcamTexture = new WebCamTexture();
		for (int i = 0; i < devices.Length; i++) {
			Debug.Log (devices[i].name);
			if(devices[i].name.Contains("USB") &&
				!devices[i].name.Equals(othercam)){
				webcamTexture.deviceName = devices[i].name;
				othercam = devices[i].name;
				break;
			}
		}
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
		
	// Update is called once per frame
	void Update () {
		//this.transform.position = new Vector3 (0,Mathf.Sin(Time.timeSinceLevelLoad)*2.5f,0);		
	}
}
