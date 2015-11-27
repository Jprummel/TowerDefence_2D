using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    private bool _attackingR = false;
    private bool _attackingL = false;

    private float _attackTimer = 0;
    private float _attackCd = 0.8f;
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

        if (_attackingR || _attackingL)
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
