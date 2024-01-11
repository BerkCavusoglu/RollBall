using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 vektor = new Vector3(15, 30, 45);
        transform.Rotate(vektor*0.01f);
    }
}
