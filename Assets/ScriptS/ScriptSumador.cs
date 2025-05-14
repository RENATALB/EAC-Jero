using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptSumador : MonoBehaviour
{
    public TMP_InputField numero1Input;
    public TMP_InputField numero2Input;
    public TextMeshProUGUI textResultado;
    void Start()
    {
        textResultado.text = "";
    }

    public void SumarYMostrarResultado()
    {
        int numero1 = int.Parse(numero1Input.text);
        int numero2 = int.Parse(numero2Input.text);

        textResultado.text = $"{numero1 + numero2}";    
    }
}
