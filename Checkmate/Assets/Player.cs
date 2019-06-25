using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    public string PlayerName;
    public int xPos;
    public int yPos;

    public Player(string name)
    {
        this.PlayerName = name;
        this.xPos = 0;
        this.yPos = 0;
    }
	
}