using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 1000;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // add a forward force
        if (Input.GetKey("w"))
        {
            // only if condition is met
            rb.AddForce(0, 0, 3000* Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            // only if condition is met
            rb.AddForce(0, 0, -2000 * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            // only if condition is met
            rb.AddForce(3000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            // only if condition is met
            rb.AddForce(-3000 * Time.deltaTime, 0, 0);
        }
    }
}
