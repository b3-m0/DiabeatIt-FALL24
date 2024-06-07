using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_phys : MonoBehaviour
{
    public void NextScene()
    {
        int nextSceneNumber = GetCurrentNumber() + 1;
        string nextScene = "phys" + nextSceneNumber;
        SceneManager.LoadSceneAsync(nextScene);
    }
    
    //This code is refrenced in PlayGame: this gets the scene number, returning 0 when there is no number, or it fails

    private int GetCurrentNumber()
        {
        //retreaves the current scene name
        string currentSceneName = SceneManager.GetActiveScene().name;
        // Extract the number from the scene name
        int tutorialNumber; //declare a variable
        //int.TryParse(input, output): the input is the scene name, replacing all characters with blank. 
        //Output is the tutorial number: "Tutorial 4" -> tutialNumber = 4
        bool success = int.TryParse(currentSceneName.Replace("Phys", ""), out tutorialNumber);
        //if success = True, then retunr tutorial number, else, 0
        if (success)
        {
            return tutorialNumber;
        }
        else
        {
            Debug.LogError("Failed to parse number.");
            return 0;
        }
    }
}