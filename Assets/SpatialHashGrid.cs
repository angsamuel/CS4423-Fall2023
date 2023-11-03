using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialHashGrid : MonoBehaviour
{
    private Dictionary<Vector2Int, List<GameObject>> grid;

    // Size of grid cells
    [SerializeField] float cellSize = 10;

    public void Awake()
    {

        grid = new Dictionary<Vector2Int, List<GameObject>>();
    }

    public void Insert(GameObject obj)
    {
        Vector2Int cell = WorldToGrid(obj.transform.position);

        if (!grid.ContainsKey(cell))
        {
            grid[cell] = new List<GameObject>();
        }
        Debug.Log(cell);

        grid[cell].Add(obj);
    }

    public List<GameObject> Request(Vector2 point)
    {
        Vector2Int cell = WorldToGrid(point);
        if (grid.ContainsKey(cell))
        {
            return grid[cell];
        }
        else
        {
            return new List<GameObject>();
        }
    }

    public void Clear()
    {
        grid.Clear();
    }

    private Vector2Int WorldToGrid(Vector2 worldPoint)
    {
        return new Vector2Int(Mathf.FloorToInt(worldPoint.x / cellSize), Mathf.FloorToInt(worldPoint.y / cellSize));
    }


    //to count as the design patter, you must allow creatures to change their cell

}