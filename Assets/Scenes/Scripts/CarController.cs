using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D wheel_f, wheel_b;
    public float power;
    Vector3 startPos;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            wheel_f.AddTorque(-power);
            wheel_b.AddTorque(-power);
        }
        if (Input.GetKey("a"))
        {
            wheel_f.AddTorque(power);
            wheel_b.AddTorque(power);
        }
    }

      private void OnCollisionEnter2D(Collision2D c)
        {
            if (c.gameObject.tag == "Respawn")
            {
                rb.velocity = Vector3.zero;
                transform.position = startPos;
            }
        }
    }

