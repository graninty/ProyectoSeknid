using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt_PersonajesCasa : MonoBehaviour
{
    public GameObject panelSlot;
    public Partida partida;
    public GameObject prefabslot;


    public void ListarPersonajes()
    {
        int numeroDeHijos = panelSlot.transform.childCount;
        for (int i = numeroDeHijos - 1; i > -1; i--)
        {
            Destroy(panelSlot.transform.GetChild(i).gameObject);
        }

        foreach (Cl_Personaje personaje in partida.Personajes)
        {
            GameObject nuevoGameObjet = Instantiate(prefabslot, panelSlot.transform);
            nuevoGameObjet.GetComponent<Bt_SlotPersonaje>().icon.sprite = personaje.avatar;
            nuevoGameObjet.GetComponent<Bt_SlotPersonaje>().text.text = personaje.nombre;
            nuevoGameObjet.GetComponent<Bt_SlotPersonaje>().personaje = personaje;
        }
    }
}
