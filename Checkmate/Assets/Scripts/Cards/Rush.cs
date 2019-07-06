using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rush : Card
{
    public Rush(Player player) : base(player)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        this.MovementTileOptions = new List<Vector2Int>();
        this.MovementTileOptions.Add(new Vector2Int(1, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
