using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoxScriptCube : MonoBehaviour
{
    private Enemy theEnemy = new Enemy();
    private int count;
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 30f;
    private NavMeshAgent agent;
    
   

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        CORE.setEnemy(this.theEnemy);
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        
        //agent.speed = 20f;
        //agent.Warp(thePlayer.transform.position);
    }
    public Enemy getEnemy()
    {
        return this.theEnemy;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }
   
    // Update is called once per frame
    void Update()
    { 
        agent.SetDestination(thePlayer.transform.position);
    }
}