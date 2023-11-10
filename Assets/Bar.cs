using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] Transform frontBar;
    [SerializeField] Transform missingBar;
    [SerializeField] float missingBarTime = .25f;
    [SerializeField] float pauseTime = .25f;
    float missingTracker = 1;
    IEnumerator currentMissingRoutine;
    float cachedValue = 1;


    [Header("Testing")]
    [SerializeField] bool testing = false;
    [SerializeField] float testValue = .5f;

    void Update(){
        if(testing){
            SetValue(testValue);
        }
    }

    public void SetValue(float f){
        f = Mathf.Clamp(f,0,1);

        if(f == cachedValue){
            return;
        }

        frontBar.transform.localScale = new Vector3(f,1,1);
        AdjustMissing(f);
        cachedValue = f;
    }

    void AdjustMissing(float f){
        float startMissing = missingTracker;

        if(currentMissingRoutine != null){
            StopCoroutine(currentMissingRoutine);
        }
        if(f > missingTracker){
            missingTracker = f;
            missingBar.transform.localScale = new Vector3(f,1,1);
        }else{
            currentMissingRoutine = AdjustMissingRoutine();
            StartCoroutine(currentMissingRoutine);
        }

        IEnumerator AdjustMissingRoutine(){
            yield return new WaitForSeconds(pauseTime);
            float timer = 0;
            while(timer < missingBarTime){
                timer+=Time.deltaTime;
                missingTracker = Mathf.Lerp(startMissing,f,timer/missingBarTime);
                missingBar.transform.localScale = new Vector3(missingTracker,1,1);
                yield return null;
            }
            yield return null;
        }
    }
}
