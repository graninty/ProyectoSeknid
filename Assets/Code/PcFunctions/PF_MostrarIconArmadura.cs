using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PF_MostrarIconArmadura
{
    public void MostrarIconArmadura(Image imagen, Cl_Armadura armadura)
    {
        if (armadura != null)
        {
            imagen.sprite = armadura.icon;
        }
        else
        {
            imagen.sprite = null;
            imagen.color = Color.black;
        }
    }
}
