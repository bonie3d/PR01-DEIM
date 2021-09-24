using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class counter6 : MonoBehaviour
{
    [SerializeField] Text myText;
    [SerializeField] float speed; 


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    IEnumerator Cronometro()
    {
        for (int n = 0; ; n++)
        {
            myText.text = "Contador: " + n;
            yield return new WaitForSeconds(speed);

           
        }
    }
}

//Corrutinas con contador de segundos con parametro speed, ejecutamos tiempos, seg, milisegundos etc