using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // Physics body that we want to interact with
    public Rigidbody2D body;

    // Speed that the character automatically moves
    public float speed = 1;

    // Direction in which the character automatically moves, default right
    public Vector2 dir = new Vector2(1, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AccelerateInDirection(Vector2 dir)
    {
        body.velocity = dir * speed;
    }
}
