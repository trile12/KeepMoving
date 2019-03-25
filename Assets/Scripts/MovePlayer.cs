using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    private Rigidbody rb;
    public float zForce = 2000f;
  //  private float moveInput;
    public float xMove = 200;
    public float speed = 200;
   

	void Start () {

        rb = GetComponent<Rigidbody>();
	}
   
    private void FixedUpdate()
    {
        // rb.AddForce(0, 0, zForce * Time.deltaTime);

        // AddForce Move

        //moveInput = Input.GetAxisRaw("Horizontal");
        //if (moveInput > 0 && transform.position.x < 6.8)
        //{

        //    rb.AddForce(xMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        //}
        //if(transform.position.x>=6.8f)
        //{
        //    transform.position = new Vector3(6.8f, transform.position.y, transform.position.z);
        //}
        //if(transform.position.x<=-6.8f)
        //{
        //    transform.position = new Vector3(-6.8f, transform.position.y, transform.position.z);
        //}
        //else if (moveInput < 0 && transform.position.x > -6.8) 
        //{

        //        rb.AddForce(-xMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        //}
        if(CLS.instance.flagg==0)
        Move();




    }

    void Move()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        if (transform.position.x >= 7)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -7)
        {
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        }
    }
}
