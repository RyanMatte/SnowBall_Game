using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_effects : MonoBehaviour
{
    public AudioSource tickSource;
    private void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision col)  
    {
       if(col.gameObject.tag == "Cube")
        {
            tickSource.Play();
        } 
    }
}
