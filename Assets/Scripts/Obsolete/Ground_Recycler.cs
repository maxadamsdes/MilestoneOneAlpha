using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Recycler : MonoBehaviour
{
    public Transform RightEdge;
    public Transform LeftEdge;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //Recycles ground when going right
        if (transform.position.x < LeftEdge.position.x)
        {
            float gap = LeftEdge.position.x - transform.position.x;
            transform.position = new Vector3(RightEdge.position.x - gap, transform.position.y, transform.position.z);
        }

        //Recycles ground when going left
        if (transform.position.x > RightEdge.position.x)
        {
            float gap = RightEdge.position.x - transform.position.x;
            transform.position = new Vector3(LeftEdge.position.x - gap, transform.position.y, transform.position.z);
        }
    }
}
