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
    public int maxHP;
    public int actualHP; //heal point
    public int maxMP;
    public int actualMP; //Magic point
    public Cl_Clase clase1;
    public Cl_Clase clase2;
    public List<int> deck1; //id skill
    public List<int> deck2; //id skill
    public Sprite avatar;
    public Sprite character;
    public int movimiento;

    public void PonerCasco(Cl_Armadura armadura)
    {
        if (armadura.ubicacion == UbicacionArmadura.CABEZA)
        {
            if (casco != null)
            {
                SacarCasco();
            }
            casco = armadura;
        }
    }

    public void SacarCasco()
    {
        if (casco != null)
        {
            casco = null;
        }
    }


}
