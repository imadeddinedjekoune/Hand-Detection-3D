using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointCalculator : MonoBehaviour
{
    public GameObject point1 , point2 ;
    public HandController hc ;
    void Start()
    {
        
    }

    void Update()
    {
        
        //hc.v_finger_1_3.x = getAngleX() ;
        //hc.v_finger_1_3.z = getAngleZ() ;

              
    }

    float getAngleX()
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

    float getAngleZ()
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

        return (float) - angleDegrees ;
    }

}
