using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject bullet;
    public Slider healthbar;

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

        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position)
            + new Vector3(0, -36.0120f, 0);
        healthbar.transform.position = screenPos;
    }
}