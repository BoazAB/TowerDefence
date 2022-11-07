using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlacementTower : MonoBehaviour
{
    public GameObject Tower;

    Ray myRay;
    RaycastHit hit;

    [SerializeField]
    private bool placeTower;

    private void Start()
    {
        placeTower = false;
    }
    private void Update()
    {
            Debug.Log("GEHAKTBAL");
            if (Input.GetMouseButtonDown(0) && placeTower == true)
            {
                Instantiate(Tower, Input.mousePosition, Quaternion.identity);
                Debug.Log(hit.point);
                placeTower = false;
            }
    }

    public void Clicked()
    {
        if (placeTower == false)
        {
            placeTower = true;
        }
    }

}
