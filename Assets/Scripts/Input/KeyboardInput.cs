using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour
{
    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;


    Animator playerMoveAnim;

     void Start()
    {

        walkSpeed = 1.0f;
        playerMoveAnim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;
        maxSpeed = curSpeed;

        
        this.GetComponent<Rigidbody2D>().velocity = 
        new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
        Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));

        if (Input.GetKey(KeyCode.D))
        {
            playerMoveAnim.Play("Running_R");
        }        
        if (Input.GetKey(KeyCode.A))
        {
            playerMoveAnim.Play("Running_L");
        }
    }
}
