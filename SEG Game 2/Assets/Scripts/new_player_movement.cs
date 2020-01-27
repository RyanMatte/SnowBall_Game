using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 1000;
    Vector3 temp;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;
        temp.x += Time.deltaTime/5;
        temp.y += Time.deltaTime/5;
        temp.z += Time.deltaTime/5;
        transform.localScale = temp;
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
