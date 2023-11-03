using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCoinText : MonoBehaviour
{
    public PlayerInfoSO coinsSO;
    public Text text;
    void Update(){
        text.text = coinsSO.coins.ToString();

    }
}
