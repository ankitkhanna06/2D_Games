using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour {

    float speed = 2f;
    float boundary = 6f;
    
    // Use this for initialization
    void Start () {
	
	}
	// Update is called once per frame
	void Update () {

        float x = this.transform.position.x;
        if(x > boundary)
        {
            speed = speed * -1;
            this.transform.position.Set(boundary, 0f, 0f);
        }
        else if (x< -boundary)
        {
            speed = speed * -1;
            this.transform.position.Set(-boundary, 0f, 0f);
        }
        this.transform.Translate(speed * Time.deltaTime,0f, 0f);
    }
}
