using UnityEngine;
using System.Collections;

public class AreaDamageTower : Tower {

    //AoE Damage turret

	// Use this for initialization
    protected override void Start()
    {
        base.Start();
        _damage = 7;
        _range = 2;
        _attackSpeed = 0.75f;
	}
}
