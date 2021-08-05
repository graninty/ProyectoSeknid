using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new Player", menuName = "Tools / ScriptableObjets / new Player", order = 0)]
[System.Serializable]
public class Gb_Player : ScriptableObject
{
    public List<Cl_Personaje> personajes = new List<Cl_Personaje>(5);
    public List<Cl_Armadura> Armaduras = new List<Cl_Armadura>();
    //public List<Cl_Consumible> Consumibles = new List<Cl_Consumible>();
    //public List<Cl_Arma> Armas = new List<Cl_Arma>();
    //public List<Cl_Material> Materiales = new List<Cl_Material>();
    public int alik; //moneda en gramos.


}
