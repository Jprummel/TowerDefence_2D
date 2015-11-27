using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{

    //Tower Stats
    [SerializeField]
    private int _damage;
    [SerializeField]
    private float _attackInterval = 1f;
    private float _attackTimer = 0f;
    [SerializeField]
    private float _range;
    [SerializeField]
    private GameObject _Bullet;
    private Animator dogAnim;
    private int _layerMask;


    // Use this for initialization
    void Start()
    {
        _layerMask = LayerMask.GetMask("Enemy");
        dogAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()

    {
        FindTarget();
        if (_attackTimer < _attackInterval)
        {
            _attackTimer += Time.deltaTime;
        }
    }

    void FindTarget()
    {
        Collider2D col = Physics2D.OverlapCircle(this.transform.position, _range, _layerMask);

        if (col != null && _attackTimer >= _attackInterval)
        {
            _attackTimer = 0f;
            Shoot(col.transform);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white; // 
        Gizmos.DrawWireSphere(this.transform.position, _range); // Draws the radius
    }

    void Shoot(Transform target)
    {
        dogAnim.Play("DogThrow_L");
        GameObject bullet = (GameObject)Instantiate(_Bullet, transform.position, Quaternion.identity);
        bullet.GetComponent<bulletMovement>().setTarget(target);
    }
}
