using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectOnScreen : MonoBehaviour
{
    public bool alreadySpawned;
    public Transform spawnObj;
    public GameObject arCamera;

    // Start is called before the first frame update
    void Start()
    {
        alreadySpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        // kijken of er al een object ingespawnd is
        if (!alreadySpawned)
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Spawn();
                alreadySpawned = true;
            }
        }
    }

    public void Spawn() 
    {
        var camera = arCamera.transform;
        Instantiate(spawnObj, arCamera.transform.position + arCamera.transform.forward * 10f, Quaternion.identity);
    }
}
