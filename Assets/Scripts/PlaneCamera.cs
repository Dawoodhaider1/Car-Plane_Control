using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCamera : MonoBehaviour
{
    public GameObject Plane;
    private Vector3 Offset = new Vector3(0f, 0f, -50f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Plane.transform.position + Offset;
    }
}
