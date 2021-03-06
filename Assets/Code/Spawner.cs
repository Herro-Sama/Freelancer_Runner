﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public GameObject[] prefabs;
    public float delay = 2;
    public bool active = true;
    public Vector2 delayRange = new Vector2(1, 2);
        
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(EnemyGenerator());

	}
	IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);

        if(active)
        {
            var newTransform = transform;

            Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position + new Vector3(0,(Random.Range(-30,140)),0), Quaternion.identity);
            ResetDelay();
        }

        StartCoroutine(EnemyGenerator());

    }
	// Update is called once per frame
	void ResetDelay ()
    {
        delay = Random.Range(delayRange.x, delayRange.y);
	}
}
