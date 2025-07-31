using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scripts : MonoBehaviour
{

    [SerializeField]
    private int _numeroEntero = 1;
    [SerializeField]
    private int _puntos = 50;
    [SerializeField]
    private int _dinero = 20;
    [SerializeField]
    private int _nivel = 29;

    [SerializeField]
    private float _numeroDecimal = 1.5f;
    [SerializeField]
    private float _experiencia = 0.1f;
    [SerializeField]
    private float _distancias = 3.5f;
    [SerializeField]
    private float _dano = 2.5f;
    [SerializeField]
    private float _vida = 100f;

    public string nombre = "Roberto";

    [SerializeField]
    private bool _isGrounder = false;

    public TMP_Text mensajeUI;




    // Start is called before the first frame update
    void Start()
    {
        mensajeUI.text = "Hola " + nombre + ", tu nivel es " + _nivel;
        //Debug.Log("Hola " + nombre + ", tu nivel es " + _nivel);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
