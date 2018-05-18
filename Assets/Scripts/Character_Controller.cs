using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour {
   float yspeed = 5f;
    float xspeed = 4f;
    bool facingRight = true;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float moveForwardBackward = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveForwardBackward * xspeed, GetComponent<Rigidbody2D>().velocity.y);
        float moveUp = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveUp * yspeed);



        Vector3 localScale = transform.localScale;
        if (moveForwardBackward > 0)
        {
            facingRight = true;
        }
        else if((moveForwardBackward < 0))
                {
            facingRight = false;
            }
        if(((facingRight) && (localScale.x >0)) || (facingRight) && (localScale.x < 0))
        {
            localScale = localScale * -1;
        }
    }
    }

