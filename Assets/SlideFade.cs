using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideFade : MonoBehaviour
{
    [SerializeField] Transform outTransform;
    [SerializeField] Transform inTransform;
    [SerializeField] float slideTime = 5;

    void Start(){
        StartCoroutine(SlideOut());
    }

    IEnumerator SlideOut()
    {
        float timer = 0;
        while(timer < slideTime){
            timer+=Time.deltaTime;
            transform.position = Vector3.Lerp(inTransform.position,outTransform.position,timer/slideTime);
            yield return null;
        }
        yield return null;
    }


}
