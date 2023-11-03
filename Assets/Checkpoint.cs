using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int checkpointID;
    public GameObject player;
    void Start(){


        SaveFlags.profile = "1";

         if(PlayerPrefs.GetInt(SaveFlags.profile+SaveFlags.checkpointString) == checkpointID){
            player.transform.position = transform.position;
         }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player"){
            PlayerPrefs.SetInt(SaveFlags.profile + SaveFlags.checkpointString,checkpointID);
        }

    }
}
