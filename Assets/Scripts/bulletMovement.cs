using UnityEngine;
using System.Collections;

public class bulletMovement : MonoBehaviour
{
    private float _speed = 150f;
    private Transform _target;
    private Rigidbody2D _rBody;
    [SerializeField]
    private float _dmg;

    // Use this for initialization
    void Start()
    {
        _rBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_target != null)
        {
            _rBody.velocity = (_target.position - transform.position).normalized * _speed * Time.deltaTime; 
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void setTarget(Transform target)
    {
        _target = target;

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Health _health = coll.GetComponent<Health>();

        if(_health != null)
        {
            _health.takeDamage(_dmg);
            Destroy(this.gameObject);

        }  
    }

}
