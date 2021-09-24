using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    [SerializeField] Text myText;


    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Hola David";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
