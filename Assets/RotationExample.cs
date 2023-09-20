using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExample : MonoBehaviour
{
    public Transform target;
    void Start(){
        //transform.eulerAngles = new Vector3(0,0,45);
        // transform.Rotate(new Vector3(0,0,45));

        //transform.localEulerAngles = new Vector3(0,0,45);

        //transform.rotation = Quaternion.LookRotation(transform.forward,target.position - transform.position);
    }

    void Update(){
        //transform.Rotate(new Vector3(0,0,45) * Time.deltaTime, Space.Self);
        //transform.Rotate(new Vector3(0,45,0) * Time.deltaTime, Space.World);
        //transform.rotation = Quaternion.LookRotation(transform.forward,target.position - transform.position);

        //transform.rotation = Quaternion.LookRotation(transform.forward,target.position - transform.position);

        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePos.z = 0;
        //transform.rotation = Quaternion.LookRotation(transform.forward,mousePos - transform.position);

        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // mousePos.z = 0;
        // Quaternion lookRotation = Quaternion.LookRotation(transform.forward,mousePos - transform.position);
        // transform.rotation = Quaternion.Lerp(transform.rotation,lookRotation,Time.deltaTime * 10);

    }

}
