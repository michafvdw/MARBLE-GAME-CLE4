using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSound : MonoBehaviour
{
    AudioSource ac;
    //Note: code was changed, sound is now called in Start ( ) instead of Awake ( )
    //If scene starts audio from object (cube) will be played
         void Start (){
               ac = GetComponent<AudioSource> ();
           }
}


