using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour
{
    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;

     void Start()
    {
        walkSpeed = 5.0f;
    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;
        maxSpeed = curSpeed;

        
        this.GetComponent<Rigidbody2D>().velocity = 
        new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
        Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
    }
}
