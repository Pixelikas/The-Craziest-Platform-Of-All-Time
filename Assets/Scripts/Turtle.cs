using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turtle : MonoBehaviour
{

    // Sets variable to player object
    public GameObject player;

    // Get enemy physics component
    public Rigidbody2D rgd;

    // Sets enemy speed
    public float speed = 2f;

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

        // Sets value and direction to enemy
        rgd.linearVelocity = transform.right * speed;   

        // Checks death condition
        if(HPManager.HP <= 0){

            // Invoke destroy method after 0.1 seconds
            Invoke("DestroyObject", 0.01f);

            // Play damage sfx
            AudioManager.audioSrc.PlayOneShot(AudioManager.deathSound);

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

         // Checks collider tag
        if(col.tag == "HitBox"){

            // Destroy turtle 
            Destroy(this.gameObject);

        }

        // Checks collider tag
        if(col.tag == "RightTrigger"){

            // Rotate enemy object to left
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            
        }

        // Checks collider tag
        if(col.tag == "LeftTrigger"){

            // Rotate enemy object to right
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

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
