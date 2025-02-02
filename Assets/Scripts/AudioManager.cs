using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // Sets variables to audio source component
    public static AudioSource audioSrc;

    // Sets variables to sound component and sfx's
    public static AudioClip lollipopSound;
    public static AudioClip damageSound;
    public static AudioClip deathSound;

    // Start is called before the first frame update
    void Start()
    {

        // Get audio component
        audioSrc = GetComponent<AudioSource>();

        // Set sound sources to variables
        lollipopSound = Resources.Load<AudioClip>("lollipop");
        damageSound = Resources.Load<AudioClip>("damage");
        deathSound = Resources.Load<AudioClip>("death");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
