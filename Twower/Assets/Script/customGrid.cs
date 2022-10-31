using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customGrid : MonoBehaviour
{

    public GameObject target;
    public GameObject structure;
    Vector2 truePos;
    public float gridSize;

    //LateUpdate runs after update
    void LateUpdate()
    {
        truePos.x = Mathf.Floor(target.transform.position.x/gridSize)*gridSize;
        truePos.y = Mathf.Floor(target.transform.position.y / gridSize) * gridSize;

        structure.transform.position = truePos;
    }
}
