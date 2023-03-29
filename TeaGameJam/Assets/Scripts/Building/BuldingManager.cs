using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldingManager : MonoBehaviour
{
    public bool isBuilding = false;
    public GameObject toBuild;

    public GameObject Grid;

    public GameObject col;
    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.B))
        {
            isBuilding = !isBuilding;
            Grid.SetActive(isBuilding);            
        }

        if (isBuilding)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);

                if (hit.transform.tag == "canBuild")
                {
                    hit.transform.GetComponent<BuildingCell>().build();
                }
            }
        }
    }
}
