using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalSystem : MonoBehaviour {
    List<Interactable> interactablelist;
    public float movespeed;
    CameraActor cam;

	// Use this for initialization
	void Start () {
		
	}
    struct Entity
    {
        public Interactable interactableobj;
    }
    Entity[] entities;
    private void Awake()
    {
        interactablelist = new List<Interactable>();
    }
    private void mover(float amt)
    {
        for (int i = 0; i < interactablelist.Count; i++)
        {
            interactablelist[i].moveinteractable(amt);
        }
    }
    private void getpendinginteractables()
    {
        int pending = 0;
        for (int i = 0; i < interactablelist.Count; i++)
        {
            if (cam.isright(interactablelist[i].getinteractableminX()))
            {
                ++pending;
            }
        }
    }
    private void FixedUpdate()
    {
        float moveamount = -1 * movespeed * Time.deltaTime;
        mover(moveamount);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
