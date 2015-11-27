using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour
{
    private Transform[] _wayPoint;
    private int _currentWayPoint = 0;
    private float _speed = 10.0f;
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
        if (_currentWayPoint == 19)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Walk();
        }

     }

    private void Walk()
    {
        Vector2 target = _wayPoint[_currentWayPoint].position;
        Vector2 currentPoint = transform.position;

        Vector2 offSet = target - currentPoint;

        _rBody.velocity = offSet.normalized * _speed * Time.deltaTime;

        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "WayPoint")
        {
            _currentWayPoint++;
        }

        Health _health = coll.GetComponent<Health>();

        if (_health != null)
        {
            _health.takeDamage(_dmg);
        }

    }

    public void setWaypoints(Transform[] waypoints)
    {
        _wayPoint = waypoints;
    }

  
}
