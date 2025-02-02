using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Create collision method by trigger
    void OnTriggerEnter2D(Collider2D col){

        // Checks collider tag
        if(col.tag == "Player"){

            // Add lollipop 1 to count
            lollipopManager.lollipopCount++;

            // Play collectible sfx
            AudioManager.audioSrc.PlayOneShot(AudioManager.lollipopSound);

            // Destroy collectable object
            Destroy(this.gameObject);

        }

    }

}
