using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "ScriptableObjects/Player")]
public class PlayerInfoSO : ScriptableObject
{
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;

    void Start(){

    }

    void Awake(){
        
    }
    public int coins = 0;
}
