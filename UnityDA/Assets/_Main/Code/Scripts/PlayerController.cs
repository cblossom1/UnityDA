using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D _rb2d;
    [SerializeField]
    private float fuerzaSalto;
    [SerializeField]
    private Vector2 direccionSalto = new Vector2(1f,3f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb2d.AddForce(direccionSalto * fuerzaSalto);
        }
        
    }
}
