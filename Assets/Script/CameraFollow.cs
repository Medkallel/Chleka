using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject chediplace;
    Vector3 range;

    void Awake()
    {

        range = transform.position - chediplace.GetComponent<Transform>().position;
    }


    void FixedUpdate()
    {

        transform.position = new Vector3(range.x + chediplace.GetComponent<Transform>().position.x, transform.position.y, range.z + chediplace.GetComponent<Transform>().position.z);
    }
}
