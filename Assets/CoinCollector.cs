using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinCollector : MonoBehaviour
{
    public PlayerInfoSO playerInfo;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Coin"){
            playerInfo.coins += 1;
            Destroy(other.gameObject);
        }
    }
}
