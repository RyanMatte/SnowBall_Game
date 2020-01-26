
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(0, 200, 200);
    }

    void Update()
    {
        
    }
}
