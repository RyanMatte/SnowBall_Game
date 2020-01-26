using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    // Start is called before the first frame update
    int collide = 0;
    public AudioSource tickSource;
    private void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "lvl1")
        {
            
            collide = collide + 50;
            Debug.Log(collide);
            tickSource.Play();
        }
    }
}
