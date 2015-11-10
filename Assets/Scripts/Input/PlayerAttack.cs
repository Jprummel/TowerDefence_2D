using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    private bool _attackingR = false;
    private bool _attackingL = false;
    private bool _attackingU = false;
    private bool _attackingD = false;

    private float _attackTimer = 0;
    private float _attackCd = 0.2f;


    [SerializeField] private Collider2D attackTriggerR;
    [SerializeField] private Collider2D attackTriggerL;
    [SerializeField] private Collider2D attackTriggerU;
    [SerializeField] private Collider2D attackTriggerD;

    void Awake()
    {
        attackTriggerR.enabled = false;
        attackTriggerL.enabled = false;
        attackTriggerU.enabled = false;
        attackTriggerD.enabled = false;
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

        }

        if (Input.GetKeyDown(KeyCode.J) && !_attackingL)
        {
            _attackingL = true;
            _attackTimer = _attackCd;
            attackTriggerL.enabled = true;
        }

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

        if (_attackingR || _attackingL || _attackingU || _attackingD)
        {
            if (_attackTimer > 0)
            {
                _attackTimer -= Time.deltaTime;
            }
            else
            {
                _attackingR = false;
                _attackingL = false;
                _attackingU = false;
                _attackingD = false;
                attackTriggerR.enabled = false;
                attackTriggerL.enabled = false;
                attackTriggerU.enabled = false;
                attackTriggerD.enabled = false;
            }
        }
    }
}
