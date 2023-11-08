using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public Command(GameObject g){
        
    }
    public abstract void Execute();
    public abstract void Undo();

}
