using UnityEngine;
using System.Collections;

public class Reticle : MonoBehaviour {
	public Camera CameraFacing; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float distance; 
		if (Physics.Raycast (new Ray(CameraFacing.transform.position,CameraFacing.transform.rotation * Vector3.forward), out hit)){
		
			distance = hit.distance;
		}else{
			distance = CameraFacing.farClipPlane * 0.95f; 
	}
		transform.position = CameraFacing.transform.position + 
			CameraFacing.transform.rotation * Vector3.forward * 2.0f;
		transform.LookAt (CameraFacing.transform.position);
		transform.Rotate (0.0f, 180.0f, 0.0f);
		//transform.localScale = Vector3.one * distance; 
	}
}