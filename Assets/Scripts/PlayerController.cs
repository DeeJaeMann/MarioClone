using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Mover mover;
    public Jumper jumper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.UpArrow) )
        {
            jumper.Jump();
        }

        if ( Input.GetKey(KeyCode.LeftArrow) )
        {
            mover.AccelerateInDirection(new Vector2(-1, 0));
        }

        if ( Input.GetKey(KeyCode.RightArrow) )
        {
            mover.AccelerateInDirection(new Vector2(1, 0));
        }
    }
}
