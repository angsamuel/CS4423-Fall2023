using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveWithCommands : MonoBehaviour
{


    public UnityEvent onLossEvent;
    public List<CommandMove> commandHistory;

    void Awake(){
        commandHistory = new List<CommandMove>();
    }

    public void Move(CommandMove c){
        c.Execute();
        commandHistory.Add(c);
    }

    public void UndoMove(){
        if(commandHistory.Count > 0){
            commandHistory[commandHistory.Count-1].Undo();
            commandHistory.RemoveAt(commandHistory.Count-1);
        }
    }



}
