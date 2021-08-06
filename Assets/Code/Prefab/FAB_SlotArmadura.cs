using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FAB_SlotArmadura : MonoBehaviour
{
    public Sprite icon;
    public string nombre;
    public Cl_Armadura armadura;

    private void Start()
    {
        icon = armadura.icon;
        nombre = armadura.nombre;
        transform.GetChild(2).GetComponent<Image>().sprite = icon;
        transform.GetChild(1).GetComponent<TMP_Text>().SetText(nombre);
    }
}
