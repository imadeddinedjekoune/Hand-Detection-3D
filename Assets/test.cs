using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject sp1 ;
    public GameObject sp2 ;
    public GameObject cy ;
    public GameObject cy2 ;



    void Update()
    {
        Vector3 direction = sp2.transform.position - sp1.transform.position;
        Debug.DrawRay(sp1.transform.position, direction, Color.red);

        Quaternion rotation = Quaternion.LookRotation(direction);

        cy2.transform.localRotation = rotation;


    }
}
