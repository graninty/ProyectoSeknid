using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cl_Skill
{
    public bool aprendida;
    public Cl_Estado[] estados;
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
    public Cl_Skill[] evolution;
    public int usos;
    public int nivel;
}
