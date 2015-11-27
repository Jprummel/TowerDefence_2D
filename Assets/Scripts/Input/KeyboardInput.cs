using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour
{
    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;
<<<<<<< HEAD
<<<<<<< HEAD

    Animator playerMoveAnim;

     void Start()
    {
<<<<<<< HEAD

        walkSpeed = 1.0f;
        playerMoveAnim = GetComponent<Animator>();
<<<<<<< HEAD
        walkSpeed = 1.0f;
=======
        walkSpeed = 5.0f;

=======
        walkSpeed = 5.0f;
>>>>>>> parent of 2a66a78... main
=======

     void Start()
    {
        walkSpeed = 5.0f;
>>>>>>> parent of 2a66a78... main
=======

     void Start()
    {
        walkSpeed = 5.0f;
>>>>>>> parent of 2a66a78... main
>>>>>>> 1ac07af549e42c9c9f64611974bac6e41962d780
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
