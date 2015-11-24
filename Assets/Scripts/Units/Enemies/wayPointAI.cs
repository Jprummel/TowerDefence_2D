using UnityEngine;
using System.Collections;

public class wayPointAI : MonoBehaviour
{   
    private Transform[] _wayPoint = new Transform[5];
    private int _currentWayPoint = 0;
    private float _rotationSpeed = 2.0f;
    private float _speed = 2.0f;

    // Use this for initialization
    void Start()
    {
        _wayPoint[0] = GameObject.Find("WayPoint1").transform;
        _wayPoint[1] = GameObject.Find("WayPoint2").transform;
        _wayPoint[2] = GameObject.Find("WayPoint3").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentWayPoint == 3)
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
        //rotation
       Quaternion Rotation = Quaternion.LookRotation(_wayPoint[_currentWayPoint].position - transform.position, Vector2.up);
       transform.rotation = Quaternion.Slerp(transform.rotation, Rotation, Time.deltaTime * _rotationSpeed);

        //movement
        Vector2 wayPointDirection = _wayPoint[_currentWayPoint].position - transform.position;
        float dir = Vector2.Dot(wayPointDirection.normalized, transform.forward);
        float speed = _speed * dir;
        transform.Translate(0, 0, Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "WayPoint")
        {
            _currentWayPoint++;
        }

    }

  
}
