using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class HandController : MonoBehaviour
{
    public GameObject armature ;
    public List<Transform> armatureList = new List<Transform>();

    public GameObject hand ;
    public List<Transform> handList = new List<Transform>();


    public List<GameObject> points = new List<GameObject>();
    


    void Start()
    {
        GetAllChilds(armature.transform,armatureList);
        GetAllChilds(hand.transform,handList);

        for (int i = 0 ; i < 3 ; i++)
        {
            points.Add(armatureList[5+i].gameObject);
            points.Add(handList[5+i].gameObject);
            points.Add(handList[6+i].gameObject);
        }

        points.Add(armatureList[11].gameObject);
        points.Add(handList[11].gameObject);
        points.Add(handList[12].gameObject);

        points.Add(armatureList[10].gameObject);
        points.Add(handList[10].gameObject);
        points.Add(handList[11].gameObject);

        points.Add(armatureList[9].gameObject);
        points.Add(handList[9].gameObject);
        points.Add(handList[10].gameObject);




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

        return (float) - angleDegrees ;
    }
    float getAngleY(GameObject point2,GameObject point1)
    {
        double dx = point2.transform.position.x - point1.transform.position.x;
        double dy = point2.transform.position.z - point1.transform.position.z;
        
        // Use the Math.Atan2 method to calculate the angle in radians
        double angleRadians = Math.Atan2(dy, dx);

        // Convert the angle from radians to degrees
        double angleDegrees = angleRadians * (180.0 / Math.PI);

        // Ensure the angle is between 0 and 360 degrees
        angleDegrees = angleDegrees - 180 ;
        angleDegrees = (angleDegrees + 360.0) % 360.0;
        Debug.Log(angleDegrees);
        return (float) angleDegrees ;
    }


    void Update()
    {
        Vector3 temp;

        // finger 1
        for (int i = 0 ; i < 3 ; i++)
        {
            temp = new Vector3(getAngleX(points[i*3+1],points[i*3+2]),
                points[i*3].transform.localEulerAngles.y,getAngleZ(points[i*3+1],points[i*3+2]));
            points[i*3].transform.localEulerAngles = temp ;
        }

        // finger 2

        temp = new Vector3(-getAngleX(points[10],points[11]),
                points[9].transform.localEulerAngles.y,-getAngleZ(points[10],points[11]));
            points[9].transform.localEulerAngles = temp ;

        temp = new Vector3(-getAngleX(points[13],points[14]),
                points[12].transform.localEulerAngles.y,-getAngleZ(points[13],points[14]));
            points[12].transform.localEulerAngles = temp ;

        temp = new Vector3(-getAngleX(points[16],points[17]),
                points[15].transform.localEulerAngles.y,-getAngleZ(points[16],points[17]));
            points[15].transform.localEulerAngles = temp ;


        
    }

    void GetAllChilds(Transform parent , List<Transform> Mylist)
    {
        foreach (Transform child in parent)
        {
            Mylist.Add(child);
            GetAllChilds(child,Mylist);
        }
    }
}
