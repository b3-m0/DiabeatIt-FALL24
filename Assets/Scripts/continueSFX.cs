/* This file ensures we have a continuous non-overlapping bg music throughout the game */

/* Below are the imports */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* continueSFX is inherited from MonoBehaviour */
public class continueSFX : MonoBehaviour
{

/* The line below is called when script is being loaded. Used for initialization */ 

  private void Awake() {

    /* Line below finds all GameObjects with a specific tag. In this case, we searcg for "background music */ 
    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("backgroundMusic");
    /* If there exists more than ONE backgroundMusic object, we get audio overlap. Therefore destroy duplicate */
    if( musicObj.Length > 1) {
      Destroy(this.gameObject);
    }
    /* Else, keep the audio running */ 
    DontDestroyOnLoad(this.gameObject);
  }
}
