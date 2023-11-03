using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTester : MonoBehaviour
{
    [SerializeField] SpatialHashGrid grid;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        List<GameObject> objects = grid.Request(transform.position);
        for(int i = 0; i<objects.Count; i++){
            objects[i].GetComponent<SpriteRenderer>().color = Color.white;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
