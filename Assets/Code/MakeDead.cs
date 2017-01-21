using UnityEngine;
using System.Collections;
using System;


public class MakeDead : MonoBehaviour
{
    private float AnimationTime = 1.6f;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        GameObject Text = GameObject.Find("Text");
        HealthScript targetScript = Text.GetComponent<HealthScript>();

        if (targetScript.Health <= 0)
        {
            anim.SetTrigger("PlayerDead");
            StartCoroutine(DeathScreen());
        }
    }
            IEnumerator DeathScreen()
            {       
                yield return new WaitForSeconds(AnimationTime);
                Application.LoadLevel("GameOver");

             }
}
