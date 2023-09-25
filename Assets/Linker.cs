using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Linker : MonoBehaviour
{
    public GameObject o_finger ;
    public Vector3 v_finger ;
    public GameObject point_Origine , point_Free;


    void Start()
    {
        v_finger = new Vector3(
            o_finger.transform.localEulerAngles.x,
            o_finger.transform.localEulerAngles.y,
            o_finger.transform.localEulerAngles.z
        );
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(getAngleZ(point_Origine,point_Free));
        Vector3 temp = new Vector3(45-getAngleX(point_Origine,point_Free),v_finger.y,Map(getAngleZ(point_Origine,point_Free),300,360,100,-50));
        o_finger.transform.localEulerAngles = temp ;
    }

    public static float Map(float value, float fromMin, float fromMax, float toMin, float toMax)
    {
        // Check for division by zero to avoid NaN results
        if (Math.Abs(fromMax - fromMin) < float.Epsilon)
        {
            throw new ArgumentException("The 'from' interval has zero width.");
        }

        // Calculate the normalized value within the 'from' interval
        float normalizedValue = (value - fromMin) / (fromMax - fromMin);

        // Map the normalized value to the 'to' interval
        float mappedValue = toMin + normalizedValue * (toMax - toMin);

        return mappedValue;
    }

    float getAngleX(GameObject point2,GameObject point1)
    {
        double dx = point2.transform.position.x - point1.transform.position.x;
        double dy = point2.transform.position.y - point1.transform.position.y;
        
        // Use the Math.Atan2 method to calculate the angle in radians
        double angleRadians = Math.Atan2(dy, dx);

        // Convert the angle from radians to degrees
        double angleDegrees = angleRadians * (180.0 / Math.PI);

        angleDegrees = angleDegrees - 270 ;
        // Ensure the angle is between 0 and 360 degrees
        angleDegrees = (angleDegrees + 360.0) % 360.0;

        return (float)angleDegrees ;
    }

    float getAngleZ(GameObject point2,GameObject point1)
    {
        double dx = point2.transform.position.y - point1.transform.position.y;
        double dy = point2.transform.position.z - point1.transform.position.z;
        
        // Use the Math.Atan2 method to calculate the angle in radians
        double angleRadians = Math.Atan2(dy, dx);

        // Convert the angle from radians to degrees
        double angleDegrees = angleRadians * (180.0 / Math.PI);

        // Ensure the angle is between 0 and 360 degrees
        angleDegrees = angleDegrees - 180 ;
        angleDegrees = (angleDegrees + 360.0) % 360.0;

        return (float) angleDegrees ;
    }
}
