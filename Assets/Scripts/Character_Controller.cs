using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    float yspeed = 5f;
    float xspeed = 4f;
    bool facingRight;
    bool rightLooking;
   
   
    void Start()
    {
        var CharTransform = gameObject.transform;
        var CharAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * xspeed, GetComponent<Rigidbody2D>().velocity.y);
        float moveY = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveY * yspeed);

        if (moveX > 0)
        {
            facingRight = true;
            gameObject.transform.GetComponent<Animator>().Play("Walk");
            //rotateMove(180);
        }
        else if (moveX < 0)
        {
            facingRight = false;
            gameObject.transform.GetComponent<Animator>().Play("Walk");
            rotateMove(180);
        }
        else
        {
            gameObject.transform.GetComponent<Animator>().Play("Idle");
        }
    }
    public void rotateMove(int rot)
    {
        gameObject.transform.Rotate(0, rot, 0);
    }
}


