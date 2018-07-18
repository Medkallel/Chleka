using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caveman : MonoBehaviour {
    public float speed =10f;
    Rigidbody2D rb2d;
    public float jumpForce = 65f;
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Animator>().SetTrigger("isJumping");
            rb2d.AddForce(Vector2.up * jumpForce);
           

        }
        if (Input.GetKeyDown(KeyCode.RightArrow)&& (speed <= 35)){
            speed += 5;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (speed > 10) )
        {
            if (speed > 6)
            {

                speed -= 5;
            }
            
        }
    }

    private void FixedUpdate()
    {

        GetComponent<Animator>().SetBool("isWalking", true);
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }
}

