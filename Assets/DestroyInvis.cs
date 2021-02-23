using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvis : MonoBehaviour
{
    // This must be in an object that has a renderer
    private void OnBecameInvisible()
    {
        //Destroy(gameObject);
        //Debug.Log("Destroyed");
        // If you made any changes in the object after gettint it from the pool,
        // return everything to default in here
        gameObject.SetActive(false);
    }
}
