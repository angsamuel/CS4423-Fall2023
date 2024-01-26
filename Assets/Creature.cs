using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Creature : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] int health = 3;
    [SerializeField] float speed = 0f;
    [SerializeField] float jumpForce = 10;

    public enum CreatureMovementType { tf, physics };
    [SerializeField] CreatureMovementType movementType = CreatureMovementType.tf;

    [Header("Flavor")]
    [SerializeField] string creatureName = "Meepis";

    [Header("Tracked Data")]
    [SerializeField] Vector3 homePosition = Vector3.zero;

    [SerializeField] GameObject box;
    Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(health);

        rb = GetComponent<Rigidbody2D>();

        SpriteRenderer sr = box.GetComponent<SpriteRenderer>();
        sr.color = Color.black;
    }



    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1,0,0);
        //transform.position += new Vector3(speed,0,0) ;
        //MoveCreature(new Vector3(-1,-1,0));
    }

    public void MoveCreature(Vector3 direction)
    {
        if (movementType == CreatureMovementType.tf)
        {
            MoveCreatureTransform(direction);
        }
        else if (movementType == CreatureMovementType.physics)
        {
            MoveCreatureRb(direction);
        }


    }

    public void MoveCreatureRb(Vector3 direction)
    {
        Vector3 currentVelocity = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = (currentVelocity) + (direction * speed);
        //rb.AddForce(direction * speed);
        //rb.MovePosition(transform.position + (direction * speed * Time.deltaTime))
    }

    public void MoveCreatureTransform(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }



}
