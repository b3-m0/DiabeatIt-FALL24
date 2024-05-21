/*
  This file is used to load IntroDialogue
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* The line below declares a class that inherits the MonoBehaviour */ 
public class IntroDialogue : MonoBehaviour
{

  /* The method below is reposonsible for initiating sceneIntroDialogue transitions */ 
  public void sceneIntroDialogueTransition() {
    
    /* uses the SceneManager namespace to Load IntroDialogue */
    SceneManager.LoadScene("IntroDialogue");
  }
}
