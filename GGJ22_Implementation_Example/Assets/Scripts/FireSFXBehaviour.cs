using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSFXBehaviour : MonoBehaviour
{
    public AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Randomize the audio source's pitch by +/- 0.05, then play it
            m_AudioSource.pitch = Random.Range(0.95f, 1.05f);
            m_AudioSource.Play();
            Debug.LogFormat("FireSFXBehaviour: Playing audio source at pitch={0}",
                            m_AudioSource.pitch);
        }
    }
}
