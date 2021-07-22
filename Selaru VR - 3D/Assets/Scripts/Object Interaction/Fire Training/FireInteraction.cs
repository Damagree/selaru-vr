using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInteraction : MonoBehaviour
{

    [SerializeField, Tooltip("Fire Health")] private float health = 100f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apar"))
        {
            health -= 20f;
        }

        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}
