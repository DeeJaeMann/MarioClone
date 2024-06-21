using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // How high we can jump
    public float jumpForce = 6f;

    private Rigidbody2D myRigidBody2D;
    private GroundDetector groundDetector;
    // Start is called before the first frame update
    void Start()
    {
        // Needs a rigidbody2d and ground detector attached to the same object
        myRigidBody2D = GetComponent<Rigidbody2D>();
        groundDetector = GetComponent<GroundDetector>();
    }

    public void Jump()
    {
        // As long as we are on the ground
        if (groundDetector == null || groundDetector.onGround == true)
        {
            // Jump
            myRigidBody2D.velocity += new Vector2(0f, jumpForce);

            // Slow down if jumping too fast
            if (myRigidBody2D.velocity.y > jumpForce)
            {
                myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, jumpForce);
            }
        }
    }
}
