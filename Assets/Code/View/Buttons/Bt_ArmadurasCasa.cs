using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt_ArmadurasCasa : MonoBehaviour
{
    public GameObject panelSlot;
    public Partida partida;
    public GameObject prefabslot;
    

    public void ListarArmaduras()
    {
        int numeroDeHijos = panelSlot.transform.childCount;
        for(int i=numeroDeHijos-1; i > -1; i--)
        {
            Destroy(panelSlot.transform.GetChild(i).gameObject);
        }

        foreach (Cl_Armadura armadura in partida.Armaduras)
        {
            GameObject nuevoGameObjet = Instantiate(prefabslot, panelSlot.transform);
            nuevoGameObjet.GetComponent<Bt_SlotArmadura>().icon.sprite = armadura.icon;
            nuevoGameObjet.GetComponent<Bt_SlotArmadura>().text.text = armadura.nombre;
            nuevoGameObjet.GetComponent<Bt_SlotArmadura>().armadura = armadura;
        }
    }

}
