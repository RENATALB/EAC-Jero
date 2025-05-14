using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalcularNumero : MonoBehaviour
{
    public TMP_InputField InputNumero;
    public TextMeshProUGUI resultadoTXT;

    void Start()
    {
        resultadoTXT.text = "";
    }

    public void CalcularTipoNumero()
    {
        int numero1 = int.Parse(InputNumero.text);
        int resto = numero1 % 2;
        if (numero1 <= 0)
        {
            resultadoTXT.text = "El número debe ser mayor a 0";
            return;
        }
        if (resto == 0)
        {
            resultadoTXT.text = "El número es par";
        } else
        {
            resultadoTXT.text = "El número es impar";
        }
    }
}
