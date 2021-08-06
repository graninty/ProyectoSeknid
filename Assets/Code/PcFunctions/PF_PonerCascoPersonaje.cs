using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF_PonerCascoPersonaje
{
    public void PonerCascoPersonaje(Cl_Personaje personaje, Gb_Player player, Cl_Armadura casco)
    {
        Cl_Armadura cabeza = personaje.casco;

        if (cabeza != null)
        {
            player.Armaduras.Add(cabeza);
            personaje.SacarCasco();
            personaje.PonerCasco(casco);
            player.Armaduras.Remove(casco);
        }
        else
        {
            personaje.PonerCasco(casco);
            player.Armaduras.Remove(casco);
        }
    }
}
