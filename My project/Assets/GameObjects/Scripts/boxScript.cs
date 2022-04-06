using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    //public Vector3 goUp, goDown, goLeft, goRight, goJump;
    public float speed  = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //goJump = new Vector3(0.0f, 1.0f, 0.0f);
        //goUp = new Vector3(0.0f, 0.0f, -1.0f);
        //goDown = new Vector3(0.0f, 0.0f, 1.0f);
        //goLeft = new Vector3(-1.0f, 0.0f, 0.0f);
        //goRight = new Vector3(1.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        if (Input.GetKeyDown("space"))
        {
            //print("space key was pressed");
            //rb.velocity = goJump * speed;
            rb.velocity = Vector3.up * speed;
        }
        else if (Input.GetKeyDown("up"))
        {
            //print("up key was pressed");
            //rb.velocity = goDown * speed;
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            //print("down key was pressed");
            //rb.velocity = goUp * speed;
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            //print("left key was pressed");
            //rb.velocity = goLeft * speed;
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            //print("right key was pressed");
            //rb.velocity = goRight * speed;
            rb.velocity = Vector3.right * speed;
        }
    }
}
