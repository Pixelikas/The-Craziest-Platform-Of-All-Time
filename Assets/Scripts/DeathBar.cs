using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBar : MonoBehaviour
{
    
    // Sets variable to get scene component
    private Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {

        // Get current scene
        currentScene = SceneManager.GetActiveScene();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Create collision method by trigger
    void OnTriggerEnter2D(Collider2D Col){

        // Checks collider tag
        if(Col.tag == "Player"){

            // Play death sfx
            AudioManager.audioSrc.PlayOneShot(AudioManager.deathSound);

            // Destroy player object
            Destroy(Col.gameObject);

            // Invoke restart method after 2 seconds
            Invoke("RestartScene", 1);

        }

         // Checks collider tag
        if(Col.tag == "Acid"){

            // Destroy player object
            Destroy(Col.gameObject);

        }

    }

    // Create restart method
    void RestartScene(){

        // Restart scene
        SceneManager.LoadScene(currentScene.buildIndex);


    }

}
