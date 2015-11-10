using UnityEngine;
using System.Collections;

public class SlowTower : Tower {

    //Turret with slow effect

	// Use this for initialization
	protected override void Start () 
    {
        base.Start();
        _damage = 5;
        _range = 1.2f;
        _attackSpeed = 1;
	}
}
