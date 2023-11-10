using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{

    public bool pauseGame = false;
    public static int pauses = 0;
    public void Show(){
        if(pauseGame){
            pauses += 1;
            Time.timeScale  = 0;


        }
        GetComponent<Canvas>().enabled = true;
    }

    public void Hide(){
        if(pauseGame){
            pauses -= 1;
        }
        if(pauseGame && pauses < 1){
            Time.timeScale = 1;
        }
        GetComponent<Canvas>().enabled = false;
    }
}
