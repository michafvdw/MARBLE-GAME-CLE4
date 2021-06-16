using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwObject : MonoBehaviour
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

/*#if UNITY_EDITOR
        if (!fingerDown && Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            fingerDown = true;
        }

        if (fingerDown)
        {
            if (Input.mousePosition.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("swipe up");
                //transform.porsition.z =
                rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            }
        }

        if (fingerDown && Input.GetMouseButtonUp(0))
        {
            fingerDown = false;
        }
#endif*/
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 50;
        GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 500, 20), thrust.ToString(), style);
    }

}
