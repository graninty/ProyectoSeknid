using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new DB_Armaduras", menuName = "Tools / ScriptableObjets / new Armaduras", order = 0)]
[System.Serializable]
public class DB_Armadura : ScriptableObject
{
    public List<Cl_Armadura> armaduras = new List<Cl_Armadura>();

    public Cl_Armadura GetArmadura(int iD)
    {
        foreach (Cl_Armadura armadura in armaduras)
        {
            if (armadura.id == iD)
            {
                return armadura;
            }
        }
        return null;
    }
}


