using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    /*public static Portal instance;
    public static int HPPersistance;
    public static int lollipopCountPersistance;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*HPPersistance = HPManager.HP;
        lollipopCountPersistance = lollipopManager.lollipopCount;*/
        
    }

    /*void Awake(){

        if(instance == null){

            instance = this;
            DontDestroyOnLoad(gameObject);

        } else if(instance != null){

            Destroy(gameObject);

        }

    }*/

    // Create collision method by trigger
    void OnTriggerEnter2D(Collider2D col){

        // Checks collider tag
        if(col.tag == "Player"){

            // Load Stage 2
            SceneManager.LoadScene(1);

        }

    }

}
