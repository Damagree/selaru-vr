using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireInteraction : MonoBehaviour
{

    [SerializeField, Tooltip("Fire Health")] private float health = 100f;

    public UnityEvent eventAfterDeath;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apar"))
        {
            health -= 20f;
        }

        if (health <= 0)
        {
            FireData.count -= 1;
            eventAfterDeath.Invoke();
        }
    }

}
