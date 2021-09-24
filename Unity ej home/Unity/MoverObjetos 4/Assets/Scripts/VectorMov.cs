using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMov : MonoBehaviour
{
    private Vector3 Initpos;

    // Start is called before the first frame update
    void Start()
    {
        Initpos = transform.position;
        print(Initpos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
