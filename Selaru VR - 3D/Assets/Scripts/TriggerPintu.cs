using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPintu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Animator myPintu = null;

    [SerializeField]
    private string pintuBuka = "";
    [SerializeField]
    private string pintuTutup = "";



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            myPintu.Play(pintuBuka, 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            myPintu.Play(pintuTutup, 0, 0.0f);
        }
    }
}
