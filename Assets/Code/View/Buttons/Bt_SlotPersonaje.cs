using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bt_SlotPersonaje : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI text;
    public Cl_Personaje personaje;
    public GameObject prefabDetallePersonaje;

    public void MostrarDetallePersonaje()
    {
        GameObject panelDetalle = GameObject.FindGameObjectWithTag("panelDetalle");

        if (panelDetalle.transform.childCount > 0)
        {
            Destroy(panelDetalle.transform.GetChild(0).gameObject);
        }
        GameObject nuevoGameObjet = Instantiate(prefabDetallePersonaje, panelDetalle.transform);
        nuevoGameObjet.GetComponent<DetallePersonaje>().icon.sprite = personaje.avatar;
        nuevoGameObjet.GetComponent<DetallePersonaje>().nombre.text = personaje.nombre;
    }
}
