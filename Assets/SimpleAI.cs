using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    Movement movement;
    [SerializeField] float viewRadius = 5;
    [SerializeField] bool activated = false;
    [SerializeField] Transform playerTransform;
    // Start is called before the first frame update
    void Awake()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,playerTransform.position) < viewRadius){
            FollowPlayer();
        }else if(activated){
            Patrol();
        }else{
            Idle();
        }
    }

    public void FollowPlayer(){
        activated = true;
        movement.MoveToward(playerTransform.position);
    }

    Vector3 patrolPos = Vector3.zero;
    public void Patrol(){
        if(Vector3.Distance(transform.position,patrolPos) < 1){
            patrolPos = transform.position + new Vector3(Random.Range(-10,10),Random.Range(-10,10),0);
        }
        movement.MoveToward(patrolPos);
    }
    public void Idle(){
        //do nothing
        movement.Stop();
    }


}
