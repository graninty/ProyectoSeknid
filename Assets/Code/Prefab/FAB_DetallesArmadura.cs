using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FAB_DetallesArmadura : MonoBehaviour
{

    public Cl_Armadura armadura;

    private void Start()
    {
        transform.GetChild(1).GetComponent<TMP_Text>().SetText(armadura.nombre);
        transform.GetChild(3).GetComponent<Image>().sprite = armadura.icon;
        transform.GetChild(4).GetComponent<TMP_Text>().SetText("defensa fisica: " + armadura.defensaFisica);
        transform.GetChild(5).GetComponent<TMP_Text>().SetText("defensa magica: " + armadura.defensaMagica);
        transform.GetChild(6).GetComponent<TMP_Text>().SetText("aumento HP: " + armadura.defensaFisica);
    }
}
