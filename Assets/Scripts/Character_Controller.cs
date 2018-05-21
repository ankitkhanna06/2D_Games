using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour {
   float yspeed = 5f;
    float xspeed = 4f;
    bool facingRight = true;
    private Animation animation;
	// Use this for initialization
	void Start () {
        var CharTransform = gameObject.transform;
        var CharAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        float moveX = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * xspeed, GetComponent<Rigidbody2D>().velocity.y);
        float moveY = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveY * yspeed);



        Vector3 localScale = transform.localScale;
        if (moveX > 0)
        {
            facingRight = true;
            //animation.Play("Walk");
        }
        else if((moveX < 0))
                {
           // facingRight = false;
           gameObject.transform.Rotate(new Vector3(0.0f,1.0f,0.0f),180);
            }
        if(((facingRight) && (localScale.x >0)) || (facingRight) && (localScale.x < 0))
        {
            localScale = localScale * -1;
        }
        /*if (Input.GetKey(KeyCode.W))
        {
            animation.Play("Walk");
            print("I am going left");
        }*/
    }
}

