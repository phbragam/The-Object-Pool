using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
        //Instantiate(asteroid, transform.position + new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity);
            GameObject a = Pool.instance.Get("Asteroid");
            if (a != null)
            {
                // Any changes in the pooled object should happen here,
                // but when you put it back to the pool, you should 
                // return the values to default
                a.transform.position = transform.position 
                    + new Vector3(Random.Range(-10,10), 0, 0);
                a.SetActive(true);
            }
        }
    }
}
