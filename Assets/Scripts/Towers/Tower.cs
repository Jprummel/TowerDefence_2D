using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {
    
    //Tower Stats
    [SerializeField] protected int   _damage;
    [SerializeField] protected float _attackSpeed;
    [SerializeField] protected float _range;
    
    private int _layerMask;

	// Use this for initialization
    protected virtual void Start () 
    {
        _layerMask = LayerMask.GetMask("Enemy");
	}
	
	// Update is called once per frame
	void Update () 
    {
        FindTarget();
	}

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(1 /_attackSpeed);
    }

    void FindTarget()
    {
        Collider2D col = Physics2D.OverlapCircle(this.transform.position, _range, _layerMask);
        Debug.Log(col);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white; // 
        Gizmos.DrawWireSphere(this.transform.position, _range); // Draws the radius
    }
}
