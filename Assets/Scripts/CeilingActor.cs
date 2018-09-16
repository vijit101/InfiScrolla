using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class CeilingActor : MonoBehaviour {
    BoxCollider2D box2d;
    private void Awake()
    {
        box2d = GetComponent<BoxCollider2D>();
    }
    public Vector2 Toprightceiling()
    {
        return box2d.bounds.max;
    }
    public Vector2 Bottomleftceiling()
    {
        return box2d.bounds.min;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
