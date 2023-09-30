using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerInput : MonoBehaviour
{
    [SerializeField] PlatformerCharacter pc;
    void Awake(){

    }
    void Update(){
        if(Input.GetKey(KeyCode.A)){
            pc.Move(new Vector3(-1,0,0));
        }else if(Input.GetKey(KeyCode.D)){
            pc.Move(new Vector3(1,0,0));
        }else{
            pc.Stop();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            pc.Jump();
        }
    }
}
