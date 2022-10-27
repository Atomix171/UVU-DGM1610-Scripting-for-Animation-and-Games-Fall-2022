using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float score;
    public TMP_Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        textScore.text = "Items Collected: "+ score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Items Collected: "+ score.ToString();
    }
}
