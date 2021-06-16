using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwObjectOnSwipe : MonoBehaviour
{
    private Vector2 startPos;
    public int pixelDistToDetect = 20;
    private bool fingerDown;
    Rigidbody rb;
    public float thrust;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            fingerDown = true;
        }

        if (fingerDown)
        {
            if (Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                thrust = (startPos.y + pixelDistToDetect) / 20;
                fingerDown = false;
                Debug.Log("swipe up");
                rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            }
        }

        if (fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            fingerDown = false;
        }
    }

}
