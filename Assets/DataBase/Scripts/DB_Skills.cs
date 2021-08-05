using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new DB_Skills", menuName = "Tools / ScriptableObjets / new Skills", order = 0)]
[System.Serializable]
public class DB_Skills : ScriptableObject
{
    public List<Cl_Skill> armaduras = new List<Cl_Skill>();
}
