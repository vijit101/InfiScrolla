using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {
    BoxCollider2D interactableboxcollider;
    Rigidbody2D interactablergbd2D;
    private void Awake()
    {
        interactableboxcollider = GetComponent<BoxCollider2D>();
        interactablergbd2D = GetComponent<Rigidbody2D>();
    }
    public void moveinteractable(float amount)
    {
        interactablergbd2D.MovePosition(interactablergbd2D.position + new Vector2(amount, 0));
    }
    public float getinteractablemaxX()
    {
        return interactableboxcollider.bounds.max.x;
    }
    public float getinteractableminX()
    {
        return interactableboxcollider.bounds.min.x;
    }
    public float getmaxtop()
    {
        return interactableboxcollider.bounds.max.y - transform.position.y;
    }
    public float getmaxbottom()
    {
        return transform.position.y - interactableboxcollider.bounds.min.y;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
