using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    public float xOffset, yOffset, zOffset;
  
    // Update is called once per frame
    void Update()
    {
        //define camera's position
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        //camera look at target
        transform.LookAt(target.transform.position);
    }
}
