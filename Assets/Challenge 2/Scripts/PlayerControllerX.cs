using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay = 1f;
    private Boolean canPress = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canPress)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canPress = false;
            Invoke("EnablePress", delay);
        }
    }

    void EnablePress()
    {
        canPress = true;
    }
}
