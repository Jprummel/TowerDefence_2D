using UnityEngine;
using System.Collections;

public class BasicTower : Tower
{

    //Basic turret (First form)

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        _damage = 5;
        _range = 0.8f;
        _attackSpeed = 0.5f;
    }
}
