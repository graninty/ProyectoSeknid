using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DB_Armaduras", menuName = "DB/create new Armaduras")]
public class DB_Armaduras : ScriptableObject
{
    public List<Cl_Armadura> Armaduras = new List<Cl_Armadura>();
}
