using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridParticipant : MonoBehaviour
{
    [SerializeField] SpatialHashGrid grid;

    void Start(){
        grid.Insert(this.gameObject);
    }
}
