using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject bullet;

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            //Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b = Pool.instance.Get("Bullet");
            // Bullet GameObject was already instantiated in the pool
            // It's not necessary to instantiate it again
            if (b != null)
            {
                b.transform.position = transform.position;
                b.SetActive(true);
            }
        }
    }
}