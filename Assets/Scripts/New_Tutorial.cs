using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void PlayGame()
    {
        int nextTutorialNumber = GetCurrentTutorialNumber() + 1;
        string nextTutorialScene = "Tutorial" + nextTutorialNumber;
        SceneManager.LoadSceneAsync(nextTutorialScene);
    }
    
    //This code is refrenced in PlayGame: this gets the scene number, returning 0 when there is no number, or it fails
    private int GetCurrentTutorialNumber()
    //retrunns an int
    {
        //retreaves the current scene name
        string currentSceneName = SceneManager.GetActiveScene().name;
        // Extract the number from the scene name
        int tutorialNumber; //declare a variable
        //int.TryParse(input, output): the input is the scene name, replacing all characters with blank. 
        //Output is the tutorial number: "Tutorial 4" -> tutialNumber = 4
        bool success = int.TryParse(currentSceneName.Replace("Tutorial", ""), out tutorialNumber);
        //if success = True, then retunr tutorial number, else, 0
        if (success)
        {
            return tutorialNumber;
        }
        else
        {
            Debug.LogError("Failed to parse tutorial number.");
            return 0;
        }
    }
}