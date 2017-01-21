using UnityEngine;
using System.Collections;

public class Despawn : MonoBehaviour {
    private float deathTime;
    public float deathDelay = 2;//two seconds delay.

    // Use this for initialization
    void Start()
    {
        deathTime = Time.time + deathDelay;
    }

    // Update is called once per frame

    void Update()
    {
        if (Time.time > deathTime)
        {
            deathTime = Time.time + deathDelay;
            Destroy(gameObject);
        }

    }
}