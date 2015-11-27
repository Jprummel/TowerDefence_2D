using UnityEngine;
using System.Collections;

public class wayPointAI : MonoBehaviour
{
    private Transform[] _wayPoint;
    private int _currentWayPoint = 0;
    private float _speed = 100.0f;
    private Rigidbody2D _rBody;
<<<<<<< HEAD:Assets/Scripts/Units/Enemies/wayPointAI.cs
<<<<<<< HEAD:Assets/Scripts/Units/Enemies/enemyBehaviour.cs
    [SerializeField]
    private float _dmg;


    
    Animator enemyAnim;
    private SoundEffects _sfx;

=======
>>>>>>> parent of 2a66a78... main:Assets/Scripts/Units/Enemies/wayPointAI.cs
=======
>>>>>>> parent of 2a66a78... main:Assets/Scripts/Units/Enemies/wayPointAI.cs
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

<<<<<<< HEAD:Assets/Scripts/Units/Enemies/wayPointAI.cs
<<<<<<< HEAD:Assets/Scripts/Units/Enemies/enemyBehaviour.cs

        Health _health = coll.GetComponent<Health>();

        if(coll.tag == "AttackTrigger")
        {
            _sfx.PlaySound(Random.Range(0, 1));
            enemyAnim.Play("Hit_L");
            StartCoroutine(Destroy());
        }
    }


        if (_health != null)
        {

            _health.takeDamage(_dmg);

            StartCoroutine(Destroy());

=======
        if(coll.tag == "AttackTrigger")
        {
            Destroy(this.gameObject);
>>>>>>> parent of 2a66a78... main:Assets/Scripts/Units/Enemies/wayPointAI.cs
=======
        if(coll.tag == "AttackTrigger")
        {
            Destroy(this.gameObject);
>>>>>>> parent of 2a66a78... main:Assets/Scripts/Units/Enemies/wayPointAI.cs
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

    IEnumerator Destroy()
    {
        _sfx.PlaySound(2);
        //enemyAnim.Play("Death");
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
