using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour {
    private Rigidbody2D rgbd2D;
    public float speed = 20;
    public float downforce = 1.5f;
    bool air = false;
    private void Awake()
    {
        rgbd2D = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        jump();
        jumpcorrection();
	}
    private void jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rgbd2D.AddForce(Vector2.up * speed, ForceMode2D.Force);
            air = true;
        }
    }
    private void jumpcorrection()
    {
        if (rgbd2D.velocity.y > 0 && air == false)
        {
            print(rgbd2D.velocity.y);
            rgbd2D.AddForce(new Vector2(0,-1)* downforce, ForceMode2D.Impulse);
        }
    }
}
