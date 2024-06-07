using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro14Script : MonoBehaviour
{
    public static string selectedAnswer;
    public Intro14Script() {
        
    }
    public void setAnswer(string answer) {
        selectedAnswer = answer;
        Debug.Log("Current answer: " + selectedAnswer);
    }
    public void loadNextScene() {
        if (selectedAnswer == "rightAnswer") SceneManager.LoadScene("Intro15_1");
        else if (selectedAnswer == "wrongAnswer") SceneManager.LoadScene("Intro15_2");
        else SceneManager.LoadScene("Intro16");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
