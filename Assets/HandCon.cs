using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class HandCon : MonoBehaviour
{
    public GameObject sp1 , sp2 ;
    public GameObject bone ;
    public int factorX , factorY ;
    public float offsetX , offsetY ;
    private Vector3 startPos ;
    private Vector3 HandPos ;




    void Start()
    {
        startPos = sp1.transform.position;
        HandPos = bone.transform.position;
    }

    void Update()
    {
        Vector3 direction ;
        double angleYZ , angleXY ;
        
        direction = (sp1.transform.position - sp2.transform.position).normalized;
        
        angleYZ = getYawAngle(direction);
        angleXY = getPitchAngle(direction);

        
        float RealAngleYZ = 0 ;
        if ((float)(-angleYZ) > 87.0f)
        {
            RealAngleYZ = 87.0f;
        }else{
            RealAngleYZ = (float)(-angleYZ);
        }

        float RealAngleXY = 0 ;
        if ((float)( angleXY ) > 50.0f)
        {
            RealAngleXY = 50.0f;
        }else
        {
            if ((float)( angleXY ) < -50.0f)
            {
                RealAngleXY = -50.0f;
            }else
            {
                RealAngleXY = (float)( angleXY );
            }
        }

        RealAngleXY = RealAngleXY * factorX + offsetX;
        RealAngleYZ = RealAngleYZ * factorY + offsetY;

   
        bone.transform.localRotation = Quaternion.Euler(new Vector3(RealAngleYZ,180,RealAngleXY));

        bone.transform.position = HandPos + sp1.transform.position - startPos;
        Vector3 temp = new Vector3(
            bone.transform.position.x,
            bone.transform.position.y,
            -Vector3.Distance(sp1.transform.position,sp2.transform.position)*10
        );
        bone.transform.position= temp;
    }

    private double getYawAngle( Vector3 direction )
    {
        double x1 = 1;
        double y1 = 0;
        double x2 = direction.y;
        double y2 = direction.z;

        double angleRadians = Math.Atan2(y2, x2) - Math.Atan2(y1, x1);
        double angleDegrees = angleRadians * 180 / Math.PI;

        if (angleDegrees < 0)
        {
            angleDegrees = angleDegrees + 180 ;
        }else
        {
            angleDegrees = angleDegrees - 180 ;
        }


        return angleDegrees;

    }
    private double getPitchAngle( Vector3 direction )
    {
        double x1 = 0;
        double y1 = 1;
        double x2 = direction.x;
        double y2 = direction.y;

        double angleRadians = Math.Atan2(y2, x2) - Math.Atan2(y1, x1);
        double angleDegrees = angleRadians * 180 / Math.PI;
        return (180 + angleDegrees)%180;
    }
}
