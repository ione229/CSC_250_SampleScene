using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CORE.AddRoomGO(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Room entered: " + this.gameObject.ToString());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
