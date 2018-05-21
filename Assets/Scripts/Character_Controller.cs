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
        animation = GetComponent<Animation>();
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
            animation.Pslay("Walk");
        }
        else if((moveX < 0))
                {
           // facingRight = false;
           animation.transform.Rotate(0f, 180f, 0f);
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

