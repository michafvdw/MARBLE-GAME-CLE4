using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//if the ball falls of the plane it resets 
public class reset : MonoBehaviour
{
    public float treshold = -50f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < treshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
