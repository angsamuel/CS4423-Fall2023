using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("MeepisPlayground");

    }

    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit(); //this does not work in the editor
    }
}
