using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour
{
    private float walkSpeed;
    private float curSpeed;

     void Start()
    {
        walkSpeed = 1.0f;
    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;

        
        this.GetComponent<Rigidbody2D>().velocity = 
        new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
        Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
    }
}
