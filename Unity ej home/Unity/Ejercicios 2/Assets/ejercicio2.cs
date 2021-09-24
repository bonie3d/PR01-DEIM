using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    // Creación de bucle

    // Start is called before the first frame update
    void Start()
    {
        int n;
        for (n = 0; n < 10; n++)
        {
            saludar();

        }
    }


    //Mi metodo de trabajo
    void saludar()
    {
        print("Hola");
    }

   
}

