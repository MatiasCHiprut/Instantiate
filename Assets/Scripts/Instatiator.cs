using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
    public GameObject ObjectToClone;
    public int maximo;
    public void CloneObj()
    {
        int contador=0;
        while (contador <= maximo)
        {
            Instantiate(ObjectToClone);
            contador++;
        }
    }
}
