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
        // Move the missile
        Y = Y + Speed * Time.deltaTime;

        // Collide with aliens
        var deadAlien = GetTouchingSprite<AlienSprite>();
        if (deadAlien != null)
        {
            deadAlien.Destroy();
            this.Destroy();
        }
    }
}
