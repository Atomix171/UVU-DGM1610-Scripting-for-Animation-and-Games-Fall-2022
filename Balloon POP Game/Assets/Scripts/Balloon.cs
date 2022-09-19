using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3; //How may clicks until the balloon pops
    public float scaleToIncrease = 0.10f; // Each time the balloon is clicked inflate 10%
    public int scoreToGive = 100;
    private ScoreManager scoreManager;



    // Start is called before the first frame update
    void Start()
    {
        // Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; // Reduce clicks by one

        //Inflate the balloon every time it is click on
        transform.localScale += Vector3.one * scaleToIncrease;
        
        // Check to see if clickToPop has reached zero. If it has then pop balloon
        if(clickToPop == 0)
        {
            // Send points to score manager and update the score
            scoreManager.IncreaseScoreText(scoreToGive);
            // Destroy this balloon
            Destroy(gameObject);
        }
    }
}
