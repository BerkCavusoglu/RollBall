using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject top;
    public Vector3 aradakiFark;
    void Start()
    {
        aradakiFark = transform.position - top.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = top.transform.position + aradakiFark;
    }
}
