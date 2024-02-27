using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown = 1.0f;
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // prevent player from spamming spacebar
        timer += Time.deltaTime;
        if (timer > coolDown)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 0.0f;
            }
        }
        
    }
}
