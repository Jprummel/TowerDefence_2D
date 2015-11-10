using UnityEngine;
using System.Collections;

public class FireTower : Tower {


    //This is the fireball/Damage turret


	// Use this for initialization
    protected override void Start() 
    {
        base.Start();
        _damage = 10;
        _range = 1;
        _attackSpeed = 1;
	}
}
