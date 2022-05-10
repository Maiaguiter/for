using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public GameObject prefab;
    public GameObject clon;
    public int NumeroCubos;
    public int Gradocubos;

    public void CloneObject()
    {
        for(int i=0; i < NumeroCubos; i++)
        {
            clon = Instantiate(prefab);
            clon.transform.Rotate(0, Gradocubos * i, 0);
            clon.transform.Translate(i, i, 0);
            //Destroy(clon,.5f);
        }
    }
    }

