using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    public GameObject[] hearts;
    public int maxHearts = 3;

    private int currentHearts;

    private void Start()
    {
        currentHearts = maxHearts;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Desactivar un corazón
            if (currentHearts > 0)
            {
                hearts[currentHearts - 1].SetActive(false);
                currentHearts--;

                // Reiniciar la escena si se pierden todos los corazones
                if (currentHearts == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}
