using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    void Update()
    {
        Rigidbody rig = GetComponent<Rigidbody>();
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                rig.useGravity = false;
                moveObject(touch);
            }
            else
            {
                rig.useGravity = true;
            }

        }
    }

    private void moveObject(Touch touch)
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector3 cursorScreenPoint = new Vector3(touch.position.x, touch.position.y, 5.0f);

        Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint(cursorScreenPoint);

        transform.position = cursorPositionInWorld;
    }
}
