using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_QuitarCasco : MonoBehaviour
{
    public Cl_Personaje personaje;
    public Gb_Player player;
    public PF_QuitarCascoPersonaje use = new PF_QuitarCascoPersonaje();

    public void QuitarCasco()
    {
        use.QuitarCasco(personaje, player);

    }
}
