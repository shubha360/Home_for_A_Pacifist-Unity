using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public Vector3 positionChange;
    private bool movingForward = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (movingForward)
        {   
            if (transform.localPosition.z < 3)
            {
                transform.localPosition += positionChange;
            } else
            {
                movingForward = false;
            }
        } else
        {
            if (transform.localPosition.z > -9)
            {
                transform.localPosition -= positionChange;
            } else
            {
                movingForward = true;
            }
        }
    }
}
