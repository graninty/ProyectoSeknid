using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_AbrirPersonajes : MonoBehaviour
{
    public GameObject personajes;
    public GameObject mochila;

    public void AbrirPersonajes()
    {

        personajes.SetActive(true);
        mochila.SetActive(false);

    }
}
