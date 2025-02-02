using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    // Sets variable to get camera target position 
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Update target position
        transform.position = new Vector3(target.position.x, 0, -10);
        
    }
}
