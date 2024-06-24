using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // Simple script to listen to see if something touches it
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // If it does touch something, print a message and destroy the coin
        Debug.Log("Coin Collected!");
        Destroy(this.gameObject);
    }
}
