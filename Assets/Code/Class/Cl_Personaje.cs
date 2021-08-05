using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cl_Personaje
{
    public string nombre;
    public Cl_Armadura casco;
    public Cl_Armadura pecho;
    public Cl_Armadura piernas;
    public Cl_Armadura guantes;
    public Cl_Armadura pies;
    public Cl_Armadura arma;
    public Cl_Armadura apoyo;
    public int HP; //heal point
    public int MP; //Magic point
    public Cl_Clase clase1;
    public Cl_Clase clase2;
    public List<Cl_Skill> deck1 = new List<Cl_Skill>(10);
    public List<Cl_Skill> deck2 = new List<Cl_Skill>(10);
    public Sprite avatar;
    public Sprite character;

    public void PonerCasco(Cl_Armadura armadura, Gb_Player player)
    {
        if (armadura.ubicacion == UbicacionArmadura.CABEZA)
        {
            if (casco != null)
            {
                SacarCasco(player);
            }
            casco = armadura;
        }
    }

    public void SacarCasco(Gb_Player player)
    {
        if (casco != null)
        {
            player.Armaduras.Add(casco);
            casco = null;
        }
    }


}
