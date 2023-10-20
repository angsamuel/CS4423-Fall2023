using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D rb;
    float damage;

    void Awake(){
       rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = new Vector3(5,0,0);
    }

    public void Launch(Vector3 targetPosition){
        rb.velocity =  targetPosition - transform.position;
    }

    public void Launch(Quaternion rotation, float speed, float newDamage){
        damage = newDamage;
        transform.rotation = rotation;
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        //Destroy(this.gameObject,10);
    }

}
