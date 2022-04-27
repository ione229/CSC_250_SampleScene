using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private Room currentRoomEnemy;

    public Enemy()
    {
        this.currentRoomEnemy = null;
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