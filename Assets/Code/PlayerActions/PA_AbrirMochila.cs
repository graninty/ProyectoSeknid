using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PA_AbrirMochila : MonoBehaviour
{
    public GameObject personajes;
    public GameObject mochila;

    public void AbrirMochila()
    {

        personajes.SetActive(false);
        mochila.SetActive(true);

    }
}
