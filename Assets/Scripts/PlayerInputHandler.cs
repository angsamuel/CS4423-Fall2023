using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{

    [SerializeField] Movement movement;
    PointsHandler pointsHandler;
    ProjectileThrower projectileThrower;

    void Awake(){
       //pointsHandler = GameObject.Find("PointsHandler").GetComponent<PointsHandler>();
       //pointsHandler = GameObject.FindObjectOfType<PointsHandler>(); //O(n*m);
       //pointsHandler = GameObject.FindGameObjectWithTag("PointsHandler").GetComponent<PointsHandler>();
       projectileThrower = GetComponent<ProjectileThrower>();

    }

    void Start(){
        pointsHandler = PointsHandler.singleton; //the second fastest option
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
        //movement.MoveTransform(vel);
        movement.MoveRB(vel);
        // pointsHandler.AddDistance(vel.magnitude * Time.deltaTime);


    }

    // Update is called once per frame
    void Update()
    {



        //projectiles
        if(Input.GetKeyDown(KeyCode.Q)){
            projectileThrower.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition));


        }
    }
}
