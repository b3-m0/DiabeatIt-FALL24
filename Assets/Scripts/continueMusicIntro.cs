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


public class continueMusicIntro : MonoBehaviour
{
  public AudioSource bgMusic;
  public static bool playing = false;
  private void Awake() {
    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("backgroundMusic");
    if(musicObj.Length > 1) {
      Destroy(this.gameObject);
    }
    DontDestroyOnLoad(this.gameObject);
    SceneManager.sceneLoaded += OnSceneLoaded;
  }
  void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
    if(scene.name == "Main Menu") {
      Destroy(this.gameObject);
    }
  }
  public void Start() {
    if (!playing) {
      bgMusic.Play();
      playing = true;
    }
  }
}
