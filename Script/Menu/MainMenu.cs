using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayMountain(){
        
        SceneManager.LoadScene("MountainIsland");
    }
    public void QuitGame(){

        Debug.Log("Quit Game!");
        Application.Quit();
    }
}
