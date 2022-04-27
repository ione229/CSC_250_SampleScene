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
        CORE.AddRoomTriggerGO(this.gameObject);
        
    }
       
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            //print("Player Entered room " + this.gameObject.ToString());
            this.thisRoom.setPlayer(CORE.getPlayer());
            print("Player is now in Room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
           //print("Enemy Entered room " + this.gameObject.ToString());
            this.thisRoom.setEnemy(CORE.getEnemy());
            //print("Enemy is now in Room: " + this.thisRoom);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            CORE.destroyRoom(this.gameObject);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            CORE.destroyRoom(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
