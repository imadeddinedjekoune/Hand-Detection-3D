using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AngleCalculator : MonoBehaviour
{
    
    public double[] tempDouble1;
    public double[] tempDouble2;
    public double[] tempDouble3;
    private double[] tempDouble;


    public List<double[]> initEulerAngles = new List<double[]>();


    public List<GameObject> Groupe_0 = new List<GameObject>();
    public List<GameObject> Groupe_1 = new List<GameObject>();
    public List<GameObject> Groupe_2 = new List<GameObject>();
   
    public List<GameObject> Groupe_3 = new List<GameObject>();
    public List<GameObject> Groupe_4 = new List<GameObject>();
    public List<GameObject> Groupe_5 = new List<GameObject>();

    /*
    public List<GameObject> Groupe_6 = new List<GameObject>();
    public List<GameObject> Groupe_7 = new List<GameObject>();
    public List<GameObject> Groupe_8 = new List<GameObject>();

    public List<GameObject> Groupe_9 = new List<GameObject>();
    public List<GameObject> Groupe_10 = new List<GameObject>();
    public List<GameObject> Groupe_11 = new List<GameObject>();
    */




    void Start()
    {
        tempDouble1 = new double[] 
        { 
            Groupe_0[2].transform.localEulerAngles.x % 360, 
            Groupe_0[2].transform.localEulerAngles.y % 360, 
            Groupe_0[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble1);

        tempDouble2 = new double[] 
        { 
            Groupe_1[2].transform.localEulerAngles.x % 360, 
            Groupe_1[2].transform.localEulerAngles.y % 360, 
            Groupe_1[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble2);

        tempDouble3 = new double[] 
        { 
            Groupe_2[2].transform.localEulerAngles.x % 360, 
            Groupe_2[2].transform.localEulerAngles.y % 360, 
            Groupe_2[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble3);


        tempDouble = new double[] 
        { 
            Groupe_3[2].transform.localEulerAngles.x % 360, 
            Groupe_3[2].transform.localEulerAngles.y % 360, 
            Groupe_3[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);

        tempDouble = new double[] 
        { 
            Groupe_4[2].transform.localEulerAngles.x % 360, 
            Groupe_4[2].transform.localEulerAngles.y % 360, 
            Groupe_4[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);

        tempDouble = new double[] 
        { 
            Groupe_5[2].transform.localEulerAngles.x % 360, 
            Groupe_5[2].transform.localEulerAngles.y % 360, 
            Groupe_5[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);
/*


        tempDouble = new double[] 
        { 
            Groupe_6[2].transform.localEulerAngles.x % 360, 
            Groupe_6[2].transform.localEulerAngles.y % 360, 
            Groupe_6[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);

        tempDouble = new double[] 
        { 
            Groupe_7[2].transform.localEulerAngles.x % 360, 
            Groupe_7[2].transform.localEulerAngles.y % 360, 
            Groupe_7[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);

        tempDouble = new double[] 
        { 
            Groupe_8[2].transform.localEulerAngles.x % 360, 
            Groupe_8[2].transform.localEulerAngles.y % 360, 
            Groupe_8[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);


        tempDouble = new double[] 
        { 
            Groupe_9[2].transform.localEulerAngles.x % 360, 
            Groupe_9[2].transform.localEulerAngles.y % 360, 
            Groupe_9[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);

        tempDouble = new double[] 
        { 
            Groupe_10[2].transform.localEulerAngles.x % 360, 
            Groupe_10[2].transform.localEulerAngles.y % 360, 
            Groupe_10[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);

        tempDouble = new double[] 
        { 
            Groupe_11[2].transform.localEulerAngles.x % 360, 
            Groupe_11[2].transform.localEulerAngles.y % 360, 
            Groupe_11[2].transform.localEulerAngles.z % 360
        };
        initEulerAngles.Add(tempDouble);
        */
    }

    void Update()
    {
        Vector3 direction ;
        Vector3 temp;
        double angleYZ , angleXY ;
        Quaternion rotation;

        // Groupe 0 
        direction = (Groupe_0[1].transform.position - Groupe_0[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[0][0] + angleXY),
            (float)(initEulerAngles[2][1]),
            (float)(initEulerAngles[0][2] + angleYZ%90)
        );
        
        rotation = Quaternion.Euler(temp);
        Groupe_0[2].transform.localRotation = rotation;


        // Groupe 1
        direction = (Groupe_1[1].transform.position - Groupe_1[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[1][0] + angleXY),
            (float)(initEulerAngles[2][1]),
            (float)(initEulerAngles[1][2] + angleYZ)
        );
        rotation = Quaternion.Euler(temp);
        Groupe_1[2].transform.localRotation = rotation;
       
        // Groupe 2
        direction = (Groupe_2[1].transform.position - Groupe_2[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[2][0] + angleXY),
            (float)(initEulerAngles[2][1]),
            (float)(initEulerAngles[2][2] + angleYZ)
        );
        rotation = Quaternion.Euler(temp);
        Groupe_2[2].transform.localRotation = rotation;
        
        /*
        // Groupe 3
        direction = (Groupe_3[1].transform.position - Groupe_3[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[3][0] - angleXY),
            (float)(initEulerAngles[3][1]),
            (float)(initEulerAngles[3][2] - angleYZ)
        );
        Groupe_3[2].transform.localEulerAngles = temp ;


        // Groupe 4
        direction = (Groupe_4[1].transform.position - Groupe_4[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[4][0] - angleXY),
            (float)(initEulerAngles[4][1]),
            (float)(initEulerAngles[4][2] - angleYZ)
        );
        Groupe_4[2].transform.localEulerAngles = temp ;
       
        // Groupe 5
        direction = (Groupe_5[1].transform.position - Groupe_5[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[5][0] - angleXY),
            (float)(initEulerAngles[5][1]),
            (float)(initEulerAngles[5][2] - angleYZ)
        );
        Groupe_5[2].transform.localEulerAngles = temp ;
       
        // Groupe 6
        direction = (Groupe_6[1].transform.position - Groupe_6[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[6][0] - angleXY),
            (float)(initEulerAngles[6][1]),
            (float)(initEulerAngles[6][2] - angleYZ)
        );
        Groupe_6[2].transform.localEulerAngles = temp ;

        // Groupe 7
        direction = (Groupe_7[1].transform.position - Groupe_7[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[7][0] - angleXY),
            (float)(initEulerAngles[7][1]),
            (float)(initEulerAngles[7][2] - angleYZ)
        );
        Groupe_7[2].transform.localEulerAngles = temp ;
       
        
        // Groupe 8
        direction = (Groupe_8[1].transform.position - Groupe_8[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[8][0] - angleXY),
            (float)(initEulerAngles[8][1]),
            (float)(initEulerAngles[8][2] - angleYZ)
        );
        Groupe_8[2].transform.localEulerAngles = temp ;
       
        // Groupe 9
        direction = (Groupe_9[1].transform.position - Groupe_9[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[9][0] - angleXY),
            (float)(initEulerAngles[9][1]),
            (float)(initEulerAngles[9][2] - angleYZ)
        );
        Groupe_9[2].transform.localEulerAngles = temp ;
       
        // Groupe 10
        direction = (Groupe_10[1].transform.position - Groupe_10[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[10][0] - angleXY),
            (float)(initEulerAngles[10][1]),
            (float)(initEulerAngles[10][2] - angleYZ)
        );
        Groupe_10[2].transform.localEulerAngles = temp ;
       
        // Groupe 11
        direction = (Groupe_11[1].transform.position - Groupe_11[0].transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        temp = new Vector3(
            (float)(initEulerAngles[11][0] - angleXY),
            (float)(initEulerAngles[11][1]),
            (float)(initEulerAngles[11][2] - angleYZ)
        );
        Groupe_11[2].transform.localEulerAngles = temp ;
        */
    }


    private double getYawAngle( Vector3 direction )
    {
        double x1 = 1;
        double y1 = 0;
        double x2 = direction.y;
        double y2 = direction.z;

        double angleRadians = Math.Atan2(y2, x2) - Math.Atan2(y1, x1);
        double angleDegrees = angleRadians * 180 / Math.PI;
        return - angleDegrees;

    }
    private double getPitchAngle( Vector3 direction )
    {
        double x1 = 0;
        double y1 = 1;
        double x2 = direction.x;
        double y2 = direction.y;

        double angleRadians = Math.Atan2(y2, x2) - Math.Atan2(y1, x1);
        double angleDegrees = angleRadians * 180 / Math.PI;
        return angleDegrees;
    }

}
