using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conter3 : MonoBehaviour
{
    [SerializeField] Text myText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Cronometro()
    {
        while (true)
        {
        print ("Hola");
        yield return new WaitForSeconds(1f);
        }
    }
}
