using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other){
        GetComponent<SpriteRenderer>().color = Color.red;
        other.GetComponent<Rigidbody2D>().velocity = other.GetComponent<Rigidbody2D>().velocity * -1;

        GetComponent<AudioSource>().pitch = Random.Range(.9f,1.1f);
        GetComponent<AudioSource>().Play();

    }

    void OnTriggerExit2D(Collider2D other)
    {

    }

}
