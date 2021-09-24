using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter5 : MonoBehaviour
{
    [SerializeField] Text myText;

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
            yield return new WaitForSeconds(1f);

            if (n >= 10)
            {
                StopCoroutine("Cronometro");
            }
        }
    }
}

          //Corrutinas con contador que se para despues de llegar a 11 en nuestro cronometro
