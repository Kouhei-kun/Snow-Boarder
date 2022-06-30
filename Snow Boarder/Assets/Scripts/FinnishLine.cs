using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinnishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem finnishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Debug.Log("You Finnished!");
            Invoke("ReloadScene", reloadDelay);
            GetComponent<AudioSource>().Play();
            finnishEffect.Play();
        }
    }
    void ReloadScene()
    {
        {
            SceneManager.LoadScene(0);
        }
    }
}
