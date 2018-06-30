using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour {

    public float moveSpd;
    private bool isRight;

    Rigidbody2D pRgd;
	// Use this for initialization
	void Start () {
        pRgd = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        MovementFunc();
    }

    private void MovementFunc()
    {
        if (Input.GetKey(KeyCode.W))
        {
            pRgd.velocity = new Vector2(pRgd.velocity.x, (moveSpd * .5f) * 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pRgd.velocity = new Vector2(pRgd.velocity.x, (moveSpd * .5f) * -1);
        }
        else
        {
            pRgd.velocity = new Vector2(pRgd.velocity.x, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            pRgd.velocity = new Vector2(moveSpd * 1, pRgd.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            pRgd.velocity = new Vector2(moveSpd * -1, pRgd.velocity.y);
        }
        else
        {
            pRgd.velocity = new Vector2(0, pRgd.velocity.y);
        }
    }
}
