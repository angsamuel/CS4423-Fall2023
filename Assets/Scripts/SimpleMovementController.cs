using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementController : MonoBehaviour
{
    [SerializeField] Movement movement;

    void Awake(){
    }

    void Start(){
    }

    void FixedUpdate(){
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.W)){
            vel.y = 1;
        }if(Input.GetKey(KeyCode.S)){
            vel.y = -1;
        }if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        movement.MoveRB(vel);

    }

}
