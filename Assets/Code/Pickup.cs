using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    private Rigidbody2D body2d;
    private Vector2 NewSpeed = Vector2.zero;
    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update() {
    }
	void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "HP^PickUp")
        {
            GameObject Text = GameObject.Find("Text");
            HealthScript targetScript = Text.GetComponent<HealthScript>();
            targetScript.Health += 10;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "DMGPickUp")
        {
            GameObject Text = GameObject.Find("Text");
            HealthScript targetScript = Text.GetComponent<HealthScript>();
            targetScript.Health -= 20;

            GameObject Text2 = GameObject.Find("Score");
            Score targetScript2 = Text.GetComponent<Score>();
            targetScript2.ScoreMultiplier = 1;

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "TeaPickUp")
        {
            GameObject Text = GameObject.Find("Score");
            Score targetScript = Text.GetComponent<Score>();
            targetScript.ScoreMultiplier += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "CoffeePickUp")
        {
            GameObject Text = GameObject.Find("Score");
            Score targetScript = Text.GetComponent<Score>();
            targetScript.PlayerScore += 20;
            Destroy(other.gameObject);
        }

    }

}

