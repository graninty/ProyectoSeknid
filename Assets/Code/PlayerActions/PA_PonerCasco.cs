using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PA_PonerCasco : MonoBehaviour
{
    public Cl_Personaje personaje;
    public Gb_Player player;
    public Cl_Armadura casco;
    public Image imagen;
    private PF_PonerCascoPersonaje use = new PF_PonerCascoPersonaje();
    private PF_MostrarIconArmadura use2 = new PF_MostrarIconArmadura();

    public void PonerCasco()
    {
        use.PonerCascoPersonaje(personaje, player, casco);
        use2.MostrarIconArmadura(imagen, casco);
    }
}
