using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conter2 : MonoBehaviour
{

    [SerializeField] Text myText;

    // Start is called before the first frame update
    void Start()
    {
        for (int n = 0; n <= 10; n++)
        {
            myText.text = "Contador:" + n;
        }

    }
    }

