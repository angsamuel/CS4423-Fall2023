using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AssignDontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        DontDestroyOnLoad(this.gameObject);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MeepisPlayground");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
