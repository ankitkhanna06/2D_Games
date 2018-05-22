using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (CircleCollider2D coinCollision)
    {
		if(coinCollision.tag == "Player")
        {
            Destroy(gameObject);
        }

	}
}
