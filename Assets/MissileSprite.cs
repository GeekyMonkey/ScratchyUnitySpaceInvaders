using UnityEngine;
using System.Collections;

public class MissileSprite : ScratchySprite {

    public float Speed = 200;

    public override void OnStart()
    {
        Wait(5, Destroy);
    }

    public override void OnUpdate()
    {
        Y = Y + Speed * Time.deltaTime;
    }
}
