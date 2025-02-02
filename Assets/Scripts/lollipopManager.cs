using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lollipopManager : MonoBehaviour
{

    // Sets lollipop text component
    public Text lollipopText;

    // Sets variable to lollipop count
    public static int lollipopCount = 0;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Updates lollipop text with lollipop count
        lollipopText.text = lollipopCount.ToString();

    }

}
