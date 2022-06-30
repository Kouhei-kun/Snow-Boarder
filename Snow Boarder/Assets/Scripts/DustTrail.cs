using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrail;
    void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.tag == "Ground")
        {
            snowTrail.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            snowTrail.Stop();
        }
    }
}
