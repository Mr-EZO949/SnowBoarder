using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float loadDelay = .5f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }   
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
