using UnityEngine;
using TMPro;
//Mis librerias

public class TallerVariables : MonoBehaviour
{
    //Crear Variables 

    //Nombre
    [SerializeField]
    private string _nombre = "Roberto";
    //Vida
    [SerializeField]
    private int _vida = 100;
    //Tiempo
    [SerializeField]
    private float _tiempo = 60f;
    //Puntos
    [SerializeField]
    private int _puntos = 20;

    //IsAlive
    [SerializeField]
    private bool _isAlive = true;

    //Crear Variables de texto //Nota: asignamos la vatiable desde el inspector

    //TMP Nombre
    [SerializeField]
    private TMP_Text _nombreMensaje;

    //TMP Vida
    [SerializeField]
    private TMP_Text _vidaMensaje;
    //TMP Tiempo
    [SerializeField]
    private TMP_Text _tiempoMensaje;
    //TMP Puntos
    [SerializeField]
    private TMP_Text _puntosMensaje;
    [SerializeField]
    private TMP_Text _isAliveMensaje;



// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        _nombreMensaje.text = "Nombre: " + _nombre;
        _vidaMensaje.text = "Vida: " + _vida;
        _tiempoMensaje.text = "Tiempo: " + _tiempo;
        _puntosMensaje.text = "Puntos: " + _puntos;



    }

    // Update is called once per frame
    void Update()
    {

        //=
        //==
        //100 < 50
        //50 > 500
        //50 >= 500
        //50 <= 500
        //50 != 505
        //!true

        // (100 < 50) && (50 != 505)
        // (50 != 505) || (100 < 50)

        if (_isAlive == true)
        {
            _isAliveMensaje.text = "Vivito y colenado n_n";
            if (_nombre == "Roberto")
            {
                _isAliveMensaje.text = "Roberto esta vivo";
            }

        }
        else if(_nombre == "Roberto")
        {
            _isAliveMensaje.text = "Roberto esta muerto";
        } 
        else
        {
            _isAliveMensaje.text = "Ojitos cerrados";
        }

    }
}
