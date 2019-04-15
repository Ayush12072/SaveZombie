using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip otherClip;
    AudioSource audioSource;
    public GameObject gameOverPanel;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = otherClip;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(audioSource.isPlaying);
        if(!audioSource.isPlaying){
            
            gameOverPanel.SetActive(true);  
        }
    }
}
