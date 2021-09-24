using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter4 : MonoBehaviour
{

    [SerializeField] Text myText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    IEnumerator Cronometro()
    {
        for (int n = 0; n <= 100; n++)
        {
            myText.text = "Contador: " + n;
            yield return new WaitForSeconds(1f);
        }    
    }
}
