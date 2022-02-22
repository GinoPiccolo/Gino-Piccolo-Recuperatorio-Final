using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextVictoriaChange : MonoBehaviour
{
    public Text text1;

    void Start()
    {
        if (Grounded.gano)
        {
            text1.text = "Victoria";
        }
        else
        {
            text1.text = "Nivel " + (Grounded.nivel + 1);
        }
    }
}
