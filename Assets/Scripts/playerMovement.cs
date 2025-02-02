using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    // Sets variable to player speed
    public float playerSpeed = 10f;

    // Get physics component
    public Rigidbody2D playerPhysics;

    // Sets variable to player jump
    public float playerJump = 30f;
    
    // Sets checkground Transform component
    public Transform checkGround;

    // Sets ground layermask
    public LayerMask Ground;

    // Sets bool to check player onground
    public bool onGround;

    // Get animator component
    public Animator animator;

    // Sets bool to check key
    public static bool key;

    // Sets object position to spawn 
    public Transform spawnHitbox;

    // Sets object to Hitbox
    public GameObject hitbox;

    // Sets variable to hitbox instance
    private GameObject hitBoxInstance;
    
    // Sets bool variable to attack cooldown
    public bool canAttack;


    // Start is called before the first frame update
    void Start()
    {

        // Sets initial value to key
        key = false;

        // Sets initial value to attack cooldown
        canAttack = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        // Sets variable to horizontal move
        float horizontalMove = Input.GetAxisRaw("Horizontal");

        // Sets player x velocity
        playerPhysics.linearVelocity = new Vector2(horizontalMove * playerSpeed, playerPhysics.linearVelocity.y);

        // Sets value to onGround state
        onGround = Physics2D.OverlapCircle(checkGround.position, 0.2f, Ground);

        // Compare horizontal move
        if(horizontalMove > 0){

            // Keep sprite without rotation
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

            // Sets walk animation
            animator.SetBool("isWalking", true);

        }

        // Compare horizontal move
        if(horizontalMove < 0){

            // Flip sprite 180 degrees
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));

            // Sets walk animation
            animator.SetBool("isWalking", true);

        }

         // Compare horizontal move
        if(horizontalMove == 0){

            // Sets walk animation
            animator.SetBool("isWalking", false);

        }

        // Checks player input key to jump
        if(Input.GetKeyDown(KeyCode.Z)){

            // Checks onground status
            if(onGround){

                // Does the jump
                playerPhysics.linearVelocity = new Vector2(playerPhysics.linearVelocity.x, playerJump);

            }

        }

         // Checks player input key to attack
        if(Input.GetKeyDown(KeyCode.X)){
            
            // Checks condition to attack
            if(canAttack){

                // Stop player movement
                StopPlayer();

                // Change bool value
                canAttack = false;

                // Spawn hitbox at spawnHitbox position
                hitBoxInstance = Instantiate(hitbox, spawnHitbox.position, spawnHitbox.rotation);

                // Sets player attack animation
                animator.SetTrigger("Attack");

                // Invokes DestroyHitBox method
                Invoke("DestroyHitBox", 0.3f);

            }


        }

    }

    // Creates a method to destroy hitbox
    void DestroyHitBox(){

        // Change bool value
        canAttack = true;

        // Restore player speed
        playerSpeed = 10f;

        // Destroy hitbox
        DestroyImmediate(hitBoxInstance, true);

        // Sets walk animation
        animator.SetBool("isWalking", true);

    }

    // Creates a method to stop player on attack
    void StopPlayer(){

        // Stop player movement
        playerSpeed = 0f;

    }
    
}
