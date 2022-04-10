using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScriptCube : MonoBehaviour
{
    private int count;
    private Rigidbody rb;
    public float speed = 15f;
    public Transform enemyPrefab;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            if(count == 3)
            {
                this.gameObject.SendMessage("DoSomething");
                Destroy(this.gameObject);
            }
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}