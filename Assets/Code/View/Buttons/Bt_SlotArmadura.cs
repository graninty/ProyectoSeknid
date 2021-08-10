using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bt_SlotArmadura : MonoBehaviour
{

    public Image icon;
    public TextMeshProUGUI text;
    public Cl_Armadura armadura;
    public GameObject prefabDetalleArmadura;

    public void MostrarDetalleArmadura()
    {
        GameObject panelDetalle = GameObject.FindGameObjectWithTag("panelDetalle");

        if (panelDetalle.transform.childCount > 0)
        {
            Destroy(panelDetalle.transform.GetChild(0).gameObject);
        }
        GameObject nuevoGameObjet = Instantiate(prefabDetalleArmadura, panelDetalle.transform);
        nuevoGameObjet.GetComponent<DetalleArmadura>().icon.sprite = armadura.icon;
        nuevoGameObjet.GetComponent<DetalleArmadura>().nombre.text = armadura.nombre;
        nuevoGameObjet.GetComponent<DetalleArmadura>().defensaFisica.text = "" + armadura.defensaFisica;
    }

}
