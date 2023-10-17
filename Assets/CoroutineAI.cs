using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineAI : MonoBehaviour
{
    Movement movement;
    [SerializeField] float viewRadius = 5;
    [SerializeField] bool activated = false;
    [SerializeField] Transform playerTransform;
    IEnumerator currentRoutine;

    // Start is called before the first frame update
    void Awake()
    {
        movement = GetComponent<Movement>();

    }

    void Start(){
        ChangeRoutine(IdleRoutine());
    }


    void ChangeRoutine(IEnumerator newRoutine){
        if(currentRoutine != null){StopCoroutine(currentRoutine);}

        currentRoutine = newRoutine;
        StartCoroutine(currentRoutine);
    }


    IEnumerator FollowPlayerRoutine()
    {
        while(Vector3.Distance(transform.position,playerTransform.position) < viewRadius){
            movement.MoveToward(playerTransform.position);
            yield return null;
        }
        ChangeRoutine(Patrol());
        yield return null;
    }



    IEnumerator Patrol(){
        Vector3 patrolPos = transform.position;

        while(true){

            if(Vector3.Distance(transform.position,playerTransform.position) <= viewRadius){
                ChangeRoutine(FollowPlayerRoutine());
            }
            if(Vector3.Distance(transform.position,patrolPos) < 1){
                patrolPos = transform.position + new Vector3(Random.Range(-10,10),Random.Range(-10,10),0);
                movement.Stop();
                yield return new WaitForSeconds(5f);
            }

            movement.MoveToward(patrolPos);
            yield return null;
        }
        yield return null;
    }


    IEnumerator IdleRoutine(){
        //do nothing
        while(true){
            movement.MoveRB(Vector3.zero);
            if(Vector3.Distance(transform.position,playerTransform.position) <= viewRadius){
                ChangeRoutine(FollowPlayerRoutine());
            }
            yield return null;

        }
        yield return null;

    }

}
