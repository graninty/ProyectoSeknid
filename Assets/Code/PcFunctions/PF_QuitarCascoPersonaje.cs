using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PF_QuitarCascoPersonaje
{
    public void QuitarCasco(Cl_Personaje personaje, Gb_Player player)
    {
        Cl_Armadura cabeza = personaje.casco;

        if (cabeza != null)
        {
            player.Armaduras.Add(cabeza);
            personaje.SacarCasco();
        }
    }
}


