using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public GameObject spawnedDog;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(spawnedDog);
            spawnedDog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
