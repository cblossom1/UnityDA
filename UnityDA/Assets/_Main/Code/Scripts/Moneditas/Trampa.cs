
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
