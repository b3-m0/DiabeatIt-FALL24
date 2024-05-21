/*
  This file is responsible for playing a sound effect when playSFX is called
  with debugging information to confirm method execution 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The class below defines a class playSFX that inherits from MonoBehaviour*/ 
public class playSFX : MonoBehaviour
{

  /*Line below defines a public variable SFX of Audiosource type.
    This allows developer to assign AudioSource component to the variable  */
    public AudioSource SFX;


    /* The line below is the declaration of the plaSFX method
       it responsible for playing the audio file needed */ 
    public void playFX() {
      /* This is a print statement for debuging purposes. Not needed in actual game */
      Debug.Log("AUDIO SHOULD PLAY RN");
      /* Line below plays the required audio file */ 
      SFX.Play();
    }
}
