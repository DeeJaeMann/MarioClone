using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    // We can tell it which screen to show in the inspector
    public GameObject winScreen;

    // Simple script to listen to see if something touches it and shows a screen
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game Won!");

        if ( winScreen != null )
        {
            winScreen.SetActive(true);
        }
    }
}
