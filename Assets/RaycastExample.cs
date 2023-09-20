using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    [SerializeField] LayerMask castMask;
    void Update(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.up,Mathf.Infinity,castMask);
        if(hit.collider != null){
            hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }


}
