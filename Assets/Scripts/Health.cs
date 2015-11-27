using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    public delegate void deathEvent();
    public event deathEvent death;

    [SerializeField]
    private float _currentHealth;
    private bool _isAlive = true;

    
    public void takeDamage(float dmg)
    {
        if (!_isAlive) return;

        _currentHealth -= dmg;

        if(_currentHealth <= 0f)
        {
            _isAlive = false;
            death();
        }
    }
}
