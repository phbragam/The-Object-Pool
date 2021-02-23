using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 velocity;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid") 
        {
            collision.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }
}
