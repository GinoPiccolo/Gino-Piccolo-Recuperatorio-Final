using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSiguienteChange : MonoBehaviour
{
    public Text text1;
    void Start()
    {
        if (Grounded.gano)
        {
            text1.text = "Siguiente Nivel";
        } else
        {
            text1.text = "Reintentar";
        }
    }
}
