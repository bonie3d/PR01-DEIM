using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScrip : MonoBehaviour
{
    public string myString = "Hola Mundo";
    public GameObject myObject; 

     //ambito publico 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola");
        myString = "Adios Mundo";
        print("Adios");
        print(myString);
        myString = "Adios Mundo";
        print(myString);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}            //Metodos y corrutinas. Ej3.a
