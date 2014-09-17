using UnityEngine;
using System.Collections;

public class GameManager : ScratchySprite {
    public GameObject[] AlienTypes;
    public int Columns = 10;

    public void CreateSwarm()
    {
        int row;
        int column;

        for (row = 0; row < AlienTypes.Length; row++)
        {
            for (column = 0; column < Columns; column++)
            {
                var pos = new Vector3(column * 20, row * 20);
                var alien = Clone(AlienTypes[row], pos);
            }
        }
    }

    public override void OnStart()
    {
        CreateSwarm();
    }
}
