using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//if the target is correct, it moves on to a new level 
public class RightTarget : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController component = other.gameObject.GetComponent<PlayerController>();
        if(component != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
