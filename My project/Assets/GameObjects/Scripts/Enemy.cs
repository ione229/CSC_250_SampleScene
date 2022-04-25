using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private string name;
    private Room currentRoomEnemy;

    public Enemy(string name)
    {
        this.name = name;
    }

    public void setRoomEnemy(Room r)
    {
        this.currentRoomEnemy = r;
    }

    public Room getRoom()
    {
        return this.currentRoomEnemy;
    }

}