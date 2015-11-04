using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

    public int damage;
    public float attackSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator AttackSpeed(int attackSpeed)
    {
        yield return new WaitForSeconds(attackSpeed);
    }
}
