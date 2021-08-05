using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cl_Skill
{
    public List<Cl_Estado> estados = new List<Cl_Estado>();
    public int id;
    public string nombre;
    public int costoMP;
    public int costoHP;
    public int enfriamiento;
    public Profesion profesion;
    public Area area;
    public EfectoSkill efecto;
    public ElementoSkill elemento;
    public TipoSkill tipo;
    public bool fisico;
    public bool magico;
    public int daño;
    public int agresion;
    public string descrippcion;
    public List<int> evolution = new List<int>(); //id de skill a la que puede evolucionar
}
