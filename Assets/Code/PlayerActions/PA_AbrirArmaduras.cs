using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PA_AbrirArmaduras : MonoBehaviour
{
    public GameObject personajes;
    public GameObject armaduras;
    public GameObject armas;
    public GameObject consumibles;

    public void AbrirMochila()
    {

        personajes.SetActive(false);
        armaduras.SetActive(true);
        armas.SetActive(false);
        consumibles.SetActive(false);

    }
}
