using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    // Sets variables to doors gameobjects
    public GameObject openDoor;
    public GameObject closedDoor;

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

            // Change bool value to key
            playerMovement.key = true;

            // Sets open door object visible
            openDoor.SetActive(true);

            // Sets closed door object invisible
            closedDoor.SetActive(false);

            // Play collectible sfx
            AudioManager.audioSrc.PlayOneShot(AudioManager.lollipopSound);

            // Destroy collectable object
            Destroy(this.gameObject);

        }

    }

}
