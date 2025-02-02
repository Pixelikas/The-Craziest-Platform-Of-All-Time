using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{

    // Sets variables to HP system
    public static int HP = 3;
    public int maxHP;
    public Image [] Heads;
    public Sprite HeadFull;
    public Sprite HeadEmpty;   

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        // Checks if heads number is greater than maxHP
        if(HP > maxHP){

            // Sets heads number to limit (maxHP)
            HP = maxHP;

        }

        // Create a loop to heads array 
        for(int i=0; i < Heads.Length; i++){

            // Checks if head index is greater than HP
            if(i < HP){

                // Enable sprite full
                Heads[i].sprite = HeadFull;

            }else{

                // Enable sprite empty
                Heads[i].sprite = HeadEmpty;

            }

            // Checks if head index is less than maxHP
            if(i < maxHP){

                // Sets (current) head visible
                Heads[i].enabled = true;

            }else{

                // Sets (current) head invisible
                Heads[i].enabled = false;

            }

        }
        
    }
}
