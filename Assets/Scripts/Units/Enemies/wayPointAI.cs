using UnityEngine;
using System.Collections;

public class wayPointAI : MonoBehaviour
{
    private Transform[] _wayPoint;
    private int _currentWayPoint = 0;
    private float _speed = 100.0f;
    private Rigidbody2D _rBody;
    // Use this for initialization
    void Start()
    {
        
        _rBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentWayPoint == 18)
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

        if(coll.tag == "AttackTrigger")
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    { 
        if(coll.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }

    public void setWaypoints(Transform[] waypoints)
    {
        _wayPoint = waypoints;
    }

  
}
