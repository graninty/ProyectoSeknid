using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cl_Clase
{
    public int ID;
    public string nombre;
    public List<Cl_Skill> skills = new List<Cl_Skill>();
    public Cl_Talent talent1;
    public Cl_Talent talent2;
    public Cl_Talent talent3;

}
