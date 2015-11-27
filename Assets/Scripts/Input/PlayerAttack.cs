using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    private bool _attackingR = false;
    private bool _attackingL = false;

    private float _attackTimer = 0;
    private float _attackCd = 0.2f;
    private float _dmg = 25f;

    Animator playerAttackAnim;
    private SoundEffects _sfx;

    [SerializeField] private Collider2D attackTriggerR;
    [SerializeField] private Collider2D attackTriggerL;

    void Awake()
    {
        playerAttackAnim = GetComponent<Animator>();
        _sfx = GetComponent<SoundEffects>();

        attackTriggerR.enabled = false;
        attackTriggerL.enabled = false;
      
    }
    void Update()
    {
        Attacking();
    }

    void Attacking()
    {
        if (Input.GetKeyDown(KeyCode.L) && !_attackingR)
        {
            _attackingR = true;
            _attackTimer = _attackCd;
            attackTriggerR.enabled = true;
            playerAttackAnim.Play("Attack1_R");
            _sfx.PlaySound(1);
        }

        if (Input.GetKeyDown(KeyCode.J) && !_attackingL)
        {
            _attackingL = true;
            _attackTimer = _attackCd;
            attackTriggerL.enabled = true;
            //playerAttackAnim.Play("");
            _sfx.PlaySound(0);
        }

<<<<<<< HEAD
        if (_attackingR || _attackingL)
=======
        if (Input.GetKeyDown(KeyCode.I) && !_attackingU)
        {
            _attackingU = true;
            _attackTimer = _attackCd;
            attackTriggerU.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && !_attackingD)
        {
            _attackingD = true;
            _attackTimer = _attackCd;
            attackTriggerD.enabled = true;
        }

<<<<<<< HEAD
=======
        if (Input.GetKeyDown(KeyCode.I) && !_attackingU)
        {
            _attackingU = true;
            _attackTimer = _attackCd;
            attackTriggerU.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && !_attackingD)
        {
            _attackingD = true;
            _attackTimer = _attackCd;
            attackTriggerD.enabled = true;
        }

<<<<<<< HEAD
>>>>>>> parent of 2a66a78... main
=======
        if (Input.GetKeyDown(KeyCode.I) && !_attackingU)
        {
            _attackingU = true;
            _attackTimer = _attackCd;
            attackTriggerU.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && !_attackingD)
        {
            _attackingD = true;
            _attackTimer = _attackCd;
            attackTriggerD.enabled = true;
        }

>>>>>>> parent of 2a66a78... main
        if (_attackingR || _attackingL || _attackingU || _attackingD)
>>>>>>> 1ac07af549e42c9c9f64611974bac6e41962d780
        {
            if (_attackTimer > 0)
            {
                _attackTimer -= Time.deltaTime;
            }
            else
            {
                _attackingR = false;
                _attackingL = false;
                attackTriggerR.enabled = false;
                attackTriggerL.enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Health _health = coll.GetComponent<Health>();

        if(_health != null )
        {
            _health.takeDamage(_dmg);
        }
    }
}
