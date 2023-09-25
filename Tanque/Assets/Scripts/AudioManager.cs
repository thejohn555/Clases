using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Referencia { get; private set; }
    AudioSource audioSource;

    
        private void Awake()
    {
        if (Referencia == null)
        {
            Referencia = this;
        }
        else
        {
            Debug.Log("cagaste");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sonido (AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }
}
