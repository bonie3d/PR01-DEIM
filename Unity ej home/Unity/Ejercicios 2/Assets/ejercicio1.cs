using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public string myString;
    public GameObject myObject;


    // Start is called before the first frame update
    void Start()
    {
        print(myString);
        myString = "Adios Mundo";
        print(myString);

    }

    
}
// Variables Públicas