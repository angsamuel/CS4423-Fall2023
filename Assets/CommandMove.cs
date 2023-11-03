using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandMove : Command
{
    GameObject go;
    Vector3 dir;
    public CommandMove(GameObject g, Vector3 direction):base(g){
        go = g;
        dir = direction;
    }
    public override void Execute(){

        go.transform.position += dir;
    }
    public override void Undo(){
        go.transform.position -= dir;
    }
}
