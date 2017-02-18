using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	// Use this for initialization

    public GameObject prefab;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	   var currentCameraPosition =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        if (Input.GetMouseButtonDown(0))
        { 
            Instantiate(prefab, currentCameraPosition, Quaternion.identity);
        }
    }
}
