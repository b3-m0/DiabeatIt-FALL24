/* This file is used to continue introduction background music 
 * It ensures the background music continues playing across different scenes
 * in the game EXCEPT if the player returns the to the Main Menu.
 * The background music plays when the game begins and while scenes load.
 
 * It contains the continueMusicIntro class and preceeding methods 
 */

 /* Below are the imports */
using System.Collections;   // enables utilization of collection structures : not relevant in this particular file 
using System.Collections.Generic;  // enabnles access of the Generic class like List<T>
using UnityEngine;  // this is needed for Unity Scripting 
using UnityEngine.SceneManagement;  // needed for scene management like loading and unloading scenes 

/* the contineuMusicIntro class ensures that the game's music correctly plays if needed.
 * This class inherits from MonoBehaviour - this is needed for unity scripting 
 * The 'pubic' keyword ensures that the class can be accessed from outside classes 
*/         
public class continueMusicIntro : MonoBehaviour
{

  /* below are instance variables */
  public AudioSource bgMusic; // holds the background music of type AudioSource. Included in UnityEngine namespace 
  public static bool playing = false;  // this tracks music currently playing. Initiazed to 'false' (no)
  
  /** the method below  is used for initializattion tasks 
   *  'Awake' is a special method in Unity 
   */
  private void Awake() {

    /* line below finds all GameObjects in the scene that has tag 'backgroundMusic'*/
    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("backgroundMusic");
    
    /* line below checks if there are more than 1 instance of the music obj arr */
    if(musicObj.Length > 1) {
      Destroy(this.gameObject);  // if so, destroy current (repeated instance). this is important to avoid auio clutter 
    }
    DontDestroyOnLoad(this.gameObject); // ensures current game object is NOT destroyed when a new scene is loaded 
    
    /* The line below subscribes method to the sceneLoaded event. When a new scene is loaded, onSceneLoaded is called */
    SceneManager.sceneLoaded += OnSceneLoaded;  
  }

  /** 
   * The method beow is called when scenes are loaded and perform specific actions 
   * No return type, hence the 'void' keyword
   *
   * Parameters: 
   * Scene scene: the scene that has just been loaded; Scene type is part of Unity Engine 
   * LoadScene mode: the mode in which the scene was loaded 
   */
  void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
    
    // cuts music if players enters Main Menu to avoid overlap 
    if(scene.name == "Main Menu") {
      Destroy(this.gameObject);
    }
  }

  /** This method immediately starts running as soon as game starts 
    * Start() is included in Unity namespace
   */ 
  public void Start() {
    
    // if music is NOT playing, start playing it 
    if (!playing) {
      bgMusic.Play();  // plays music. Play() method is built in in AudioSource 
      playing = true;
    }
  }
}
