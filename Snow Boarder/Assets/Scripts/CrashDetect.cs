using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    [SerializeField] float reloadDelay = .8f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    
    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed=true;
            FindObjectOfType<PlayerController>().DisableControls();
            Debug.Log("You Snapped Your Neck!");
            Invoke("ReloadScene", reloadDelay);
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
        }
    } 
    
    void ReloadScene()
    {
        {
            SceneManager.LoadScene(0);
        } 
    }
}
