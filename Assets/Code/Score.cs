using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour

{
    Text TextBox;
    float PlayerScore = 0;
    // Use this for initialization
    void Start()
    {
        TextBox = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerScore += (1 * Time.deltaTime);
        TextBox.text = "Score = " + (int)PlayerScore;
    }
}