using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    void Pickup(Creature creature){
        creature.GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
