using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour
{
    Text TextBox;
    public float Health = 100;
    // Use this for initialization
    void Start()
    {
        TextBox = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Health -= (3 * Time.deltaTime);
        TextBox.text = "health = " + (int)Health;

        if (Health > 100)
        {
            Health = 100;
        }
    }
}