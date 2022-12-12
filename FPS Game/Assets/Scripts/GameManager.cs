using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Flag Stats")]
    public bool hasFlag;
    public bool flagPlaced;

    // Start is called before the first frame update
    void Start()
    {
        // Flag bools
        hasFlag = false;
        flagPlaced = false;

        Time.timeScale = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(flagPlaced == true)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("YOU WIN! YOU ARE VICTORIOUS!");
        Time.timeScale = 0;
    }

    
    public void PlaceFlag()
    {
        flagPlaced = true;
    }


}
