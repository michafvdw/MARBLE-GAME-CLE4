using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    private static int spawnLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
        spawnObjectOnTouch.spawnLimit = 0;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 500, 20), "If this text is gone, you can respawn cube");
    }
}
