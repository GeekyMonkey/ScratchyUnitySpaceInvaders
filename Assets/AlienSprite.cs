using UnityEngine;
using System.Collections;

public class AlienSprite : ScratchySprite {

    public override void OnStart()
    {
        Forever(1, NextCostume);
    }

}
