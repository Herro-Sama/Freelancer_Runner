using UnityEngine;
using System.Collections;
using System;

public class IsDead : StateMachineBehaviour {
    Animator animator;

    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        GameObject Text = GameObject.Find("Text");
        HealthScript targetScript = Text.GetComponent<HealthScript>();
        if (targetScript.Health <= 0)
        {
            animator.SetTrigger("PlayerDead");
        }

    }
}

