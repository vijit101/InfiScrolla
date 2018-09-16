using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActor : MonoBehaviour {
    private Camera cam;
    private void Awake()
    {
        cam = GetComponent<Camera>();
    }
    // Use this for initialization
    void Start () {
		
	}
    public float leftbound()
    {
        return cam.transform.position.x - cam.aspect * cam.orthographicSize;
    }
    public float rightbound()
    {
        return cam.transform.position.x + cam.aspect * cam.orthographicSize;
    }
    public bool isleft(float Worldx)
    {
        return Worldx < leftbound();
    }
    public bool isright(float Worldx)
    {
        return Worldx > rightbound();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
