using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA_VerDetalleArmadura : MonoBehaviour
{
    Cl_Armadura armadura;
    public GameObject panel;
    public GameObject prefab;
    private void Start()
    {
        armadura = GetComponent<FAB_SlotArmadura>().armadura;
    }

    public void VerDetalleArmadura()
    {
        GameObject nuevoGameObjet = Instantiate(prefab, panel.transform);
        nuevoGameObjet.GetComponent<FAB_DetallesArmadura>().armadura = armadura;
    }
}
