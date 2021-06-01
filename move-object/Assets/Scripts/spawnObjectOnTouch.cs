using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjectOnTouch : MonoBehaviour
{
    public Transform spawnObj;
    public float spawnLimit = 0;

    void Update()
    {
        if (spawnLimit < 1)
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Vector3 cameraPos = Camera.main.transform.position;
                Quaternion cameraRot = Camera.main.transform.rotation;
                Instantiate(spawnObj, new Vector3(cameraPos.x, cameraPos.y, cameraPos.z + 3), cameraRot);
                spawnLimit++;
            }
        }


#if UNITY_EDITOR
        if (spawnLimit < 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 cameraPos = Camera.main.transform.position;
                Quaternion cameraRot = Camera.main.transform.rotation;
                Instantiate(spawnObj, new Vector3(cameraPos.x, cameraPos.y, cameraPos.z + 3), cameraRot);
                spawnLimit++;
            }
        }
#endif
    }
}
