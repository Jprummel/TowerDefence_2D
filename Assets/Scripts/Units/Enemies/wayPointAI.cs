using UnityEngine;
using System.Collections;

public class wayPointAI : MonoBehaviour
{
    private Transform[] _wayPoint;
    private int _currentWayPoint = 0;
    private float _speed = 100.0f;
    private Rigidbody2D _rBody;
    
    Animator enemyAnim;
    private SoundEffects _sfx;
    // Use this for initialization
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        _sfx = GetComponent<SoundEffects>();
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
            _sfx.PlaySound(Random.Range(0, 1));
            enemyAnim.Play("Hit_L");
            StartCoroutine(Destroy());
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    { 
        if(coll.gameObject.tag == "Bullet")
        {
            StartCoroutine(Destroy());
        }
    }

    public void setWaypoints(Transform[] waypoints)
    {
        _wayPoint = waypoints;
    }

    IEnumerator Destroy()
    {
        _sfx.PlaySound(2);
        //enemyAnim.Play("Death");
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
