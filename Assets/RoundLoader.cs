using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public float progress = 1f;
    Material material;
    void Start(){
        GetComponent<Image>().material = new Material(GetComponent<Image>().material);
        material = GetComponent<Image>().material;
    }
    void Update()
    {
        material.SetFloat("_Progress",progress);
    }


}
