using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PA_AbrirArmaduras : MonoBehaviour
{
    public GameObject personajes;
    public GameObject armaduras;
    public GameObject armas;
    public GameObject consumibles;
    public GameObject layout;
    public Gb_Player player;
    public GameObject prefab;


    public void AbrirMochila()
    {

     //   personajes.SetActive(false);
     //   armaduras.SetActive(true);
     //   armas.SetActive(false);
     //   consumibles.SetActive(false);

        foreach (Cl_Armadura armadura in player.Armaduras)
        {
            GameObject nuevoGameObjet = Instantiate(prefab, layout.transform);
            nuevoGameObjet.GetComponent<FAB_SlotArmadura>().armadura = armadura;
        }

    }
}
