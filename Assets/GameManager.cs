using UnityEngine;
using System.Collections;

public class GameManager : ScratchySprite {
    public GameObject[] AlienTypes;
    public int Columns = 10;
    public float SwarmStep = 20;

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

        Forever(1, MoveSwarm);
    }

    public void MoveSwarm()
    {
        bool hitEdge = false;
        var aliens = GetSprites<AlienSprite>();
        foreach (var alien in aliens)
        {
            alien.X += SwarmStep;
            if (alien.IsTouchingEdge())
            {
                hitEdge = true;
            }
        }
        if (hitEdge)
        {
            SwarmStep = SwarmStep * -1;
            foreach (var alien in aliens)
            {
                alien.Y -= 20;
            }
        }
    }
}
