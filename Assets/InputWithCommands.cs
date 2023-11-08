using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputWithCommands : MonoBehaviour
{
    
    [SerializeField] MoveWithCommands mwc;

    void Update(){
        if(Input.GetKeyDown(KeyCode.W)){
            mwc.Move(new CommandMove(mwc.gameObject,new Vector3(0,1,0)));
        }else if(Input.GetKeyDown(KeyCode.S)){
            mwc.Move(new CommandMove(mwc.gameObject,new Vector3(0,-1,0)));
        }else if(Input.GetKeyDown(KeyCode.A)){
            mwc.Move(new CommandMove(mwc.gameObject,new Vector3(-1,0,0)));
        }else if(Input.GetKeyDown(KeyCode.D)){
            mwc.Move(new CommandMove(mwc.gameObject,new Vector3(1,0,0)));
        }

        if(Input.GetKeyDown(KeyCode.U)){
            mwc.UndoMove();
        }

    }
}
