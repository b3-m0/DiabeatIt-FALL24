/* This file is used to load a specific scene named "ChapterDivider 
 * The purpose is to enable scene transitions 
 */

/* Imports go below */ 
using System.Collections;  // this interfaces that define various collections of objetcs like lists and arrays
using System.Collections.Generic; // Allows access to generic classes like List<T>
using UnityEngine; // essential for all Unity scripts 
using UnityEngine.SceneManagement; // needed for loading and unloading scenes 

/** This class contains the sceneChapterDivider method
 * This method calls the sceneManager class and loads "ChapterDivider" 
 *
 * Keyword MonoBehaviour: any unity script MUST inherit for MonoBehavior
 * Wed define it as public so that outside classes can access this particular class 
 */
public class ChapterDividerInsulin : MonoBehaviour
{
    /* This method loads the aforementioned scene 
     * This method has no return type 
     */
    public void sceneChapterDivider()
    {
        SceneManager.LoadScene("ChapterDivider");
    }
}


