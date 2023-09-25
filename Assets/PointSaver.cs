using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[ExecuteInEditMode]

public class PointSaver : MonoBehaviour
{
    public GameObject[] handPoints;
    
    void Start()
    {
        try{
            string data = "[526, 32, 0, 480, 39, -21, 443, 57, -33, 417, 69, -44, 392, 73, -54, 464, 149, -13, 450, 195, -22, 445, 223, -33, 440, 248, -41, 496, 159, -14, 492, 209, -20, 490, 238, -29, 488, 264, -38, 525, 156, -18, 527, 205, -28, 527, 232, -37, 525, 257, -44, 553, 145, -24, 565, 184, -35, 573, 207, -40, 578, 231, -44]";

            data = data.Remove(0, 1);
            data = data.Remove(data.Length-1, 1);
            string[] points = data.Split(',');
            
            for ( int i = 0; i<21; i++)
            {

                float x = 32.83f -float.Parse(points[i * 3])/100;
                float y = float.Parse(points[i * 3 + 1]) / 100;
                float z = float.Parse(points[i * 3 + 2]) / 100;

                handPoints[i].transform.localPosition = new Vector3(x, y, z);

            }
        }catch (Exception err)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
