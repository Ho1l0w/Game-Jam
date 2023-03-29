using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCell : MonoBehaviour
{
    public bool isBuilded = false;

    public GameObject Building;

    public Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }
    public void build()
    {
        if (!isBuilded)
        {
            Building = FindObjectOfType<BuldingManager>().toBuild;

            Instantiate(Building, pos + new Vector3(1, 0, 0), Quaternion.identity);

            isBuilded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
