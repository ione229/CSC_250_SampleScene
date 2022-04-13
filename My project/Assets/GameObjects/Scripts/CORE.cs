using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
       
    
    private static List<GameObject> theRooms = new List<GameObject>();
    public static void display()
    {
        print("Woot");
    }
    public static void AddRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }
    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < 20; i++)
        {
            print(Random.Range(1,20));
            if(i <= 5)
            {
                Transform l = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                l.transform.position += new Vector3(-2 * speed * Time.deltaTime, 20, 5);
            }
            else if(6 <= i && i <= 10)
            {
                Transform b = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                b.transform.position += new Vector3(80, 20, -2 * speed * Time.deltaTime);
            }
            else if(11 <= i && i <= 15)
            {
                Transform f = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                f.transform.position += new Vector3(80, 20, 2 * speed * Time.deltaTime);
            }
            else if(16 <= i && i <= 20)
            {
                Transform r = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                r.transform.position += new Vector3(2 * speed * Time.deltaTime, 20, 5);
            }
        }*/
        /*int random_number = Random.Range(1, 20);
        if (random_number < 5)
        {
            print("this worked");
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;
            //rb.velocity = constantSpeed * (GetComponent<Rigidbody>().velocity.normalized);
        }
        else if(5 <= random_number && random_number < 10)
        {
            print("this also worked");
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * speed;
            //rb.velocity = constantSpeed * (GetComponent<Rigidbody>().velocity.normalized);
        }
        else if(10 <= random_number && random_number < 15)
        {
            print("also worked");
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * speed;
            //rb.velocity = constantSpeed * (GetComponent<Rigidbody>().velocity.normalized);
        }
        else
        {
            print("this also worked");
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * speed;
            //rb.velocity = constantSpeed * (GetComponent<Rigidbody>().velocity.normalized);
        }*/
        for (int i = 0; i < 100; i++)
        {
            Transform t = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            Rigidbody rb = t.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(Random.Range(10,30), Random.Range(10,30), Random.Range(10,30));
        }
        
    }
     
    
    void Update()
    {
        
    }
}
