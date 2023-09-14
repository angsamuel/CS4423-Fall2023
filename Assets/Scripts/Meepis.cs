using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Meepis : MonoBehaviour
{

    [SerializeField] int hp = 4;
    [SerializeField] float stamina = 10.0f;
    [SerializeField] string meepisName = "Meepis";
    [SerializeField] GameObject stick;
    [SerializeField] float speed = 9;

    void Awake(){

    }

    // Start is called before the first frame update
    void Start()
    {

        CopyStickColor();
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Transform>()


        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed*Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(speed*Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0,speed*Time.deltaTime,0);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.position -= new Vector3(0,speed*Time.deltaTime,0);
        }

        if(Input.GetKeyDown(KeyCode.Q)){ //meepis stealth mode
            //GetComponent<SpriteRenderer>().color = Color.black;
            transform.localScale *= 1 + (.5f * Time.deltaTime);
        }



    }

    //set the stick color to match meepis
    public void CopyStickColor(){
        stick.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
    }

    public int GetHP(){
        return hp;
    }
}
