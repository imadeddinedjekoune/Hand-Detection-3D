using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class HandTracking : MonoBehaviour
{
    // Start is called before the first frame update
    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    void Start()
    {
        timeLeft = updateInterval;
        
    }

    // Update is called once per frame
    
    public float updateInterval = 0.5f; // The interval at which to update the FPS display
    private float accum = 0f; // FPS accumulated over the interval
    private int frames = 0; // Frames drawn over the interval
    private float timeLeft; // Time left for current interval
    public float shift = 7 ;

    void Update()
    {
        try{
            string data = udpReceive.data;

            data = data.Remove(0, 1);
            data = data.Remove(data.Length-1, 1);
            string[] points = data.Split(',');
            
            //0        1*3      2*3
            //x1,y1,z1,x2,y2,z2,x3,y3,z3

            for ( int i = 0; i<21; i++)
            {

                float x = 32.83f -float.Parse(points[i * 3])/100;
                float y = float.Parse(points[i * 3 + 1]) / 100;
                float z = float.Parse(points[i * 3 + 2]) / 100;

                handPoints[i].transform.localPosition = new Vector3(x, y, z);

            }
        }catch (Exception err)
        {
            //Debug.Log(err.ToString);
        }


    }
}