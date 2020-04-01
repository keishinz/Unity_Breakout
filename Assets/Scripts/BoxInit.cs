using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{
    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    private void Awake()
    {
        GameObject masterObject = GameObject.Find("Master");
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                GameObject obj = Instantiate(boxObjPrefab, boxesObj.transform);
                obj.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
                obj.GetComponent<Destroyer>().masterObj = masterObject;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
