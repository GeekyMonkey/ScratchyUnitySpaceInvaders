using UnityEngine;
using System.Collections;

public class PlayerSprite : ScratchySprite
{
    public float Speed = 100;
    public GameObject MissileType;

    public override void OnUpdate()
    {
        // Movement
        float direction = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1;
        }
        X += direction * Speed * Time.deltaTime;

        // Weapons
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Clone(MissileType);
        }
    }
}
