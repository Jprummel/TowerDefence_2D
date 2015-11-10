using UnityEngine;
using System.Collections;

public class EnemyTestMovement : MonoBehaviour {
    [SerializeField]
    private float _movementSpeed;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 newVelocity = new Vector2(_movementSpeed, 0f);
        rb2d.velocity = newVelocity;
	}
}
