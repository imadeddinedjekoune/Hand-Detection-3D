using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] handPoints;
    public string data = "249, 131, 0, 305, 129, -25, 359, 136, -41, 404, 134, -57, 442, 126, -73, 349, 233, -21, 383, 277, -40, 404, 302, -57, 422, 326, -69, 322, 255, -23, 348, 311, -39, 364, 346, -54, 378, 375, -66, 293, 263, -28, 311, 319, -45, 324, 353, -58, 336, 382, -67, 262, 260, -37, 262, 308, -52, 263, 338, -59, 266, 364, -64";
    
    void Start()
    {
        string[] points = data.Split(',');
            
            
        for ( int i = 0; i<21; i++)
        {

            float x = float.Parse(points[i * 3])/100;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;

            handPoints[i].transform.localPosition = new Vector3(x, y, z);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
