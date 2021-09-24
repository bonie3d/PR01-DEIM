using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectSuma : MonoBehaviour
{
    private Vector3 Initpos;
    [SerializeField] Vector3 DestPost;
    private Vector3 FinalPost;


    // Start is called before the first frame update
    void Start()
    {
        Initpos = transform.position;
        FinalPost = Initpos + DestPost;

        print(FinalPost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
