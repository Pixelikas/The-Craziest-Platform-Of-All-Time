using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Traps : MonoBehaviour
{

    // Sets variable to player object
    public GameObject player;

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

        // Checks death condition
        if(HPManager.HP <= 0){

            // Invoke destroy method after 0.1 seconds
            Invoke("DestroyObject", 0.01f);

            // Restart stage values to HP and lollipop
            HPManager.HP = 3;
            lollipopManager.lollipopCount = 0;

            // Invoke restart method after 2 seconds
            Invoke("RestartScene", 2);

        }
        
    }

    // Create collision method by trigger
    void OnTriggerEnter2D(Collider2D col){

        // Checks collider tag
        if(col.tag == "Player"){

            // Subtract HP
            HPManager.HP--;

            // Play collectible sfx
            AudioManager.audioSrc.PlayOneShot(AudioManager.damageSound);

        }

    }

    // Create restart method
    void RestartScene(){

        // Restart scene
        SceneManager.LoadScene(currentScene.buildIndex);


    }

    // Create destroy object method
    void DestroyObject(){

        // Destroy player object
        Destroy(player.gameObject);

    }

}
