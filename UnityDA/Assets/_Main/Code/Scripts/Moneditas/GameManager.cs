using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public int vida;
    
    public int puntos;

    [SerializeField]
    private TMP_Text textoPuntos;
    
    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntos.text = "Puntos: " + puntos;
    }
}
