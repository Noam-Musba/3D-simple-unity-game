using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forward_force = 8000f;
    public float side_force = 120f;
    public float jump_force = 300f;

    public bool jump_move = false;
    public bool right_move = false;
    public bool left_move = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            jump_move = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            right_move = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left_move = true;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (right_move)
        {
            right_move = false;
            rb.AddForce(side_force * Time.deltaTime * Vector3.right, ForceMode.VelocityChange);
        }
        else if (jump_move)
        {
            jump_move = false;
            rb.AddForce(jump_force * Time.deltaTime * Vector3.up, ForceMode.Impulse);
        }
        else if (left_move)
        {
            left_move = false;
            rb.AddForce(side_force * Time.deltaTime * Vector3.left, ForceMode.VelocityChange);
        }
        
        // constant force forward
        rb.AddForce(0, 0, forward_force * Time.deltaTime);

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
