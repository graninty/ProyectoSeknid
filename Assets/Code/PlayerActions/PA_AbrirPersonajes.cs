using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_AbrirPersonajes : MonoBehaviour
{
    public GameObject personajes;
    public GameObject armaduras;
    public GameObject armas;
    public GameObject consumibles;

    public void AbrirPersonajes()
    {

        personajes.SetActive(true);
        armaduras.SetActive(false);
        armas.SetActive(false);
        consumibles.SetActive(false);

    }
}
