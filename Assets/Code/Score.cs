using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
public float ScoreMultiplier = 1;


    Text TextBox;
    public float PlayerScore = 0;
    

    // Use this for initialization
    void Start()
    {
        TextBox = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerScore += (ScoreMultiplier * Time.deltaTime);
        TextBox.text = "Score = " + (int)PlayerScore + " Multiplier = " + (int)ScoreMultiplier;
    }
}