using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float startTime = 0.0f;
    public float delayTime = 40.0f;


    // Update is called once per frame
    void Update()
    {
        startTime++;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)  && startTime > delayTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            startTime = 0.0f;
        }
    }
}
