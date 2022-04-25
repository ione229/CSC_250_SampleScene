using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTriggerScript : MonoBehaviour
{
    private Room thisRoom;
    
    // Start is called before the first frame update
    void Start()
    {
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
    }
       
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            print("Player Entered room " + this.gameObject.ToString());
            this.thisRoom.setPlayer(CORE.getPlayer());
            print("Player is now in Room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            print("Enemy Entered room " + this.gameObject.ToString());
            this.thisRoom.setEnemy(CORE.getEnemy());
            print("Enemy is now in Room: " + this.thisRoom);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
