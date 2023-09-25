using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attatcher : MonoBehaviour
{
    public List<GameObject> bones = new List<GameObject>();
    public List<GameObject> points = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0 ; i < bones.Count ; i++  )
        {
            bones[i].transform.position = points[i].transform.position ; 
        }
        
    }
}
