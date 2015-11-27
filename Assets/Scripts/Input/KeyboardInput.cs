using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour
{
    private float walkSpeed;
    private float curSpeed;

    Animator playerMoveAnim;

     void Start()
    {
<<<<<<< HEAD
        walkSpeed = 1.0f;
=======
        playerMoveAnim = GetComponent<Animator>();
        walkSpeed = 5.0f;
>>>>>>> origin/master
    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;

        
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
