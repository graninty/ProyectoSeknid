using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PA_QuitarCasco : MonoBehaviour
{
    public Cl_Personaje personaje;
    public Gb_Player player;
    public Image imagen;
    private PF_QuitarCascoPersonaje use = new PF_QuitarCascoPersonaje();
    private PF_MostrarIconArmadura use2 = new PF_MostrarIconArmadura();

    public void QuitarCasco()
    {
        use.QuitarCascoPersonaje(personaje, player);
        use2.MostrarIconArmadura(imagen, null);
    }
}
