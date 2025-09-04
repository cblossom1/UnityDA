using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] private TMP_Text textIntroduccion;
    [SerializeField] private TMP_InputField inputField;

    private int edad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        textIntroduccion.text = "Introduce tu edad";
    }

    // Update is called once per frame
   public void CalcularGrupo()
    {
        edad = int.Parse(inputField.text);
        if (edad  <=12 )
        {
            Debug.Log("Eres un niño");
        }
        else if (edad >12 && edad <=18)
        {
            Debug.Log("Eres un adolescente");
        }
        else if (edad >18 && edad <=25)
        {
            Debug.Log("Eres un adulto joven");
        }
        else if (edad > 25 && edad <= 60)
        {
            Debug.Log("Eres un adulto");
        }
        else if (edad >60)
        {
            Debug.Log("Eres un adulto mayor");
        }
    }
}
