using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMove : Card
{

    // Start is called before the first frame update
    void Start()
    {
        this.CardName = "KnightMove";
        this.MovementTileOptions = new List<Vector2Int>();
        this.MovementTileOptions.Add(new Vector2Int(2, 1));
        this.MovementTileOptions.Add(new Vector2Int(-2, -1));
        this.MovementTileOptions.Add(new Vector2Int(1, 2));
        this.MovementTileOptions.Add(new Vector2Int(-1, -2));
        this.MovementTileOptions.Add(new Vector2Int(1, -2));
        this.MovementTileOptions.Add(new Vector2Int(-1, 2));
        this.MovementTileOptions.Add(new Vector2Int(-2, 1));
        this.MovementTileOptions.Add(new Vector2Int(2, -1));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
