using UnityEngine;
using System.Collections;

public class ExplosionSprite : ScratchySprite
{
    public override void OnStart()
    {
        Repeat(4, 0.1f, NextCostume);
        Wait(0.4f, Destroy);
    }
}
