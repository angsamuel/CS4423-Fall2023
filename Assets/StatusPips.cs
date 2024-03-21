using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPips : MonoBehaviour
{
    public int value;
    int cachedValue;
    public GameObject prefab;
    public List<GameObject> pips;
    // Start is called before the first frame update
    void Start(){

    }

    void Update(){
        FillBar();
    }

    void FillBar(){
        if(cachedValue != value){
            foreach (GameObject g in pips){
                Destroy(g);
            }
            pips.Clear();
            for(int i = 0; i<value; i++){
                pips.Add(Instantiate(prefab,transform));
            }
            cachedValue = value;
        }
    }
}
